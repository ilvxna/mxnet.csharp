﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mxnet.csharp;

namespace test.console
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Symbol data1 = Symbol.Variable("data1");
            Symbol data2 = Symbol.Variable("data2");
            Symbol p = data1 + data2;

            Console.WriteLine(p);

        }
    }
}
