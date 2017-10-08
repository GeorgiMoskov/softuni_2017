using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloName(Console.ReadLine());
        }

        static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
