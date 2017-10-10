using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double sumLeft=0;
            double sumRight=0;


            for(int i = 0; i < arr.Length; i++)
            {
                for(int y = 0; y < i; y++)
                {
                    sumLeft += arr[y];
                }

                for(int y = i + 1; y < arr.Length; y++)
                {
                    sumRight += arr[y];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                    
                }

                sumLeft = 0;
                sumRight = 0;
                
            }

            Console.WriteLine("no");

        }
    }
}
