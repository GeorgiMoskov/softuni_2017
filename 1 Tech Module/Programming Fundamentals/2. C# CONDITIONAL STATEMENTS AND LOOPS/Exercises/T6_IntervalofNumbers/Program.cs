using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for(int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
