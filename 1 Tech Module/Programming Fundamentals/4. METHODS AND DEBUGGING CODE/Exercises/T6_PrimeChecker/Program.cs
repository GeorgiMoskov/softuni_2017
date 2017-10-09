using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));

        }

        static bool IsPrime(long num)
        {
            if(num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for(long i = 2; i <= Math.Sqrt(num); i++)
                {
                    if(num%i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
