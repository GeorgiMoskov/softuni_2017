using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_FastPrimeCheckRefactor
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;

                for (int y = 2; y <=Math.Sqrt(i); y++)
                {
                    if (i % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }



        }
    }
}
