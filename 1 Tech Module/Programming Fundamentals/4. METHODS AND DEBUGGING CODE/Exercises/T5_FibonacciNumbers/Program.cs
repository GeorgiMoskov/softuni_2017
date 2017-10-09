using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));

        }

        static int Fib(int n)
        {
            

            if (n == 0 || n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else
            {
                int numBeforeOneStep=2;
                int numBeforeTwoSteps = 1;
                int fibnum=0;

                for (int i = 3; i <= n; i++)
                {
                    fibnum = numBeforeOneStep + numBeforeTwoSteps;
                    numBeforeTwoSteps = numBeforeOneStep;
                    numBeforeOneStep = fibnum;
                }

                return fibnum;

                
            }
        }

    }
}
