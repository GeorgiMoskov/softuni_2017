using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = 0;

            while (true)
            {
                try
                {
                    var intNum = int.Parse(Console.ReadLine());
                    br++;
                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine(br);

        }
    }
}
