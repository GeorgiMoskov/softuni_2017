﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_ExchangeVarsValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            b = b + a;
            a = b - a;
            b = b - a;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
