﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mxnet.numerics.single;
using mxnet.numerics.int32;
using mxnet.numerics.int64;
using mxnet.numerics.nbase;

namespace mxnet.numerics.single
{
    public partial struct SingleCalculator : ICalculator<float>
    {
        public float Sum(float[] data)
        {
            return data.Sum();
        }

        public int Argmax(float[] data)
        {
            return !data.Any()
                ? -1
                : data
                    .Select((value, index) => new {Value = value, Index = index})
                    .Aggregate((a, b) => (a.Value >= b.Value) ? a : b)
                    .Index;
        }
    }

 

    public partial class SingleNArray : NArray<float, SingleCalculator, SingleNArray>
    {
        public SingleNArray()
        {

        }
        public SingleNArray(Shape shape) : base(shape)
        {
        }

        public SingleNArray(Shape shape, float[] data) : base(shape, data)
        {

        }
        #region Convert
        public SingleNArray ToSingle()
        { 
            return new SingleNArray(shape, storage.Select(s => (float)s).ToArray());
        }

        public  Int32NArray ToInt32()
        {
            return new Int32NArray(shape, storage. Select(s => (int)s).ToArray());
        }

        public Int64NArray ToInt64()
        {
            return new Int64NArray(shape, storage.Select(s => (long)s).ToArray());
        }
        #endregion
    }
}
