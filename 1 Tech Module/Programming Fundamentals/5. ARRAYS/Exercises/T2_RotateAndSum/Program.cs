using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] arrSum = new long[arr.Length];

            long pushRightTimes = long.Parse(Console.ReadLine());


            for (long i = 1; i <= pushRightTimes; i++)
            {

                for (long y = 0; y <= arr.Length-1; y++)
                {
                    arrSum[((y + i) % (arr.Length))] += arr[y];
                }

            }

            for (long i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write("{0} ", arrSum[i]);
            }



        }
    }
}
