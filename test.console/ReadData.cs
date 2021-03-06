﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using mxnet.csharp;
using OpenCvSharp;

namespace test.console
{

    class DataBatch: IDataBatch
    {
        public string bucket_key { get; }

        public List<NDArray> data { get; }

        public List<NDArray> label{ get; }


        public DataBatch(List<NDArray> datas, List<NDArray> labels)
        {
            this.data = datas;
            this.label = labels;
        }

        public Dictionary<string, Shape> provide_data { get; }
        public Dictionary<string, Shape> provide_label { get; }
    }


    class ReadData : IDataIter
    {
        private readonly string _path;
        private readonly int _batch_size;

        public ReadData(string path, int batch_size)
        {
            _path = path;
            _batch_size = batch_size;

            provide_data = new Dictionary<string, Shape>
            {
                {"data", new Shape((uint) _batch_size, 3, 60, 20)}
            };

            provide_label = new Dictionary<string, Shape>
            {
                {"softmax_label", new Shape((uint) _batch_size, 4)}
            };
            var files = System.IO.Directory.EnumerateFiles(_path).ToList();

            _data_s = new List<float[]>();
            _label_s = new List<float[]>();
            foreach (var file in files)
            {
                float[] data = ReadFile(file);
                float[] label = ReadLabel(file);

                _data_s.Add(data);
                _label_s.Add(label);
            }
             _rnd = new Random();
            Reset();
        }

        public IEnumerator<IDataBatch> GetEnumerator()
        {
   

            var count = _data_s.Count / _batch_size + 1;
            for (int batch_index = 0; batch_index < count; batch_index++)
            {
                List<float> datas = new List<float>();
                List<float> labels = new List<float>();
                for (int i = 0; i < _batch_size; i++)
                {
                    var index = batch_index * _batch_size + i;
                    if (index >= _data_s.Count)
                    {
                        index = _data_s.Count - 1;
                    }
    

                    datas.AddRange(_data_s[index]);
                    labels.AddRange(_label_s[index]);
                    //   datas.Add();
                    // labels.Add(new NDArray(label, new Shape((uint)_batchSize, 4)));

                }
                var data_all = new List<NDArray> { new NDArray(datas.ToArray(), new Shape((uint)_batch_size, 3, 60, 20)) };
                var label_all = new List<NDArray> { new NDArray(labels.ToArray(), new Shape((uint)_batch_size, 4)) };
                //   data_all.First().SetValue(3);
                // label_all.First().SetValue(3);
                yield return new DataBatch(data_all, label_all);
            }

        }

        private static readonly Regex Reg = new Regex("(\\d*)-.*", RegexOptions.Compiled);
        private List<float[]> _data_s;
        private List<float[]> _label_s;
        private Random _rnd;

        private float[] ReadLabel(string path)
        {
            //return new float[] {9, 4, 3, 7};
            var m = Reg.Match(path);
            return m.Groups[1].Value.ToCharArray().Select(s => (float)((int)s - (int)'0')).ToArray();
        }

        private float[] ReadFile(string path)
        {
            Mat mat = new Mat(path);
            Vec3b[] array = new Vec3b[20 * 60];
            mat.GetArray(0, 0, array);


            var c1 = array.Select(s => s.Item0).Select(s => (float)(s / 255.0));
            var c2 = array.Select(s => s.Item1).Select(s => (float)(s / 255.0));
            var c3 = array.Select(s => s.Item2).Select(s => (float)(s / 255.0));


            return c1.Concat(c2).Concat(c3).ToArray();
        }

 

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string default_bucket_key { get; set; }

        public Dictionary<string, Shape> provide_data { get; set; }
        public Dictionary<string, Shape> provide_label { get; set; }

        public int batch_size { get { return _batch_size; } }
        public void Reset()
        {
      
            int[] shuffle_indices = Enumerable.Range(0, _data_s.Count).OrderBy(x => _rnd.Next()).ToArray();
            _data_s = shuffle_indices.Select(s => _data_s[s]).ToList();
            _label_s = shuffle_indices.Select(s => _label_s[s]).ToList();
        }
    }
}
