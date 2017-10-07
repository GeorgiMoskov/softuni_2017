using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSumBound = int.Parse(Console.ReadLine());

            var sum = 0;
            var countComb = 0;

            for(int i = n; i >= 1; i--)
            {
                for(int y = 1; y <= m; y++)
                {
                    sum += (i * y)*3;
                    countComb++;

                    if(sum >= maxSumBound)
                    {
                        Console.WriteLine("{0} combinations",countComb);
                        Console.WriteLine("Sum: {0} >= {1}",sum,maxSumBound);
                        return;
                    }
                }
            }

            Console.WriteLine("{0} combinations", countComb);
            Console.WriteLine("Sum: {0}", sum);

        }
    }
}
