using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (var i1 = a; i1 <= b - 4; i1++)
            {
                for (var i2 = i1+1; i2 <= b - 3; i2++)
                {
                    for (var i3 = i2+1; i3 <= b - 2; i3++)
                    {
                        for (var i4 = i3+1; i4 <= b - 1; i4++)
                        {
                            for (var i5 = i4+1; i5 <= b; i5++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", i1, i2, i3, i4, i5);
                            }
                        }
                    }
                }

            }
        }
    }
}
