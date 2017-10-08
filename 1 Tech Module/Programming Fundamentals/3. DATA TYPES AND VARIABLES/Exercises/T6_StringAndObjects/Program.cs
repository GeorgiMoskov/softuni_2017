using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            object objVarStr = str1 +" "+ str2;

            string str3 = (string)objVarStr;

            Console.WriteLine(str3);
        }
    }
}
