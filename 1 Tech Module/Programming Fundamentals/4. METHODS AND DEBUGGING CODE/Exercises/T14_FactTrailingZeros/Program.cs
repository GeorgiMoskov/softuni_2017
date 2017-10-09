using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace T14_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            int br = 0;

            while(sum%10 == 0)
            {
                br++;
                sum = sum / 10;
            }

            Console.WriteLine(br);
            
        }
    }
}
