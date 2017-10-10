using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double diffSize = double.Parse(Console.ReadLine());
            int br = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int y = i+1; y < arr.Length; y++)
                {
                    if( Math.Abs(Math.Abs(arr[i]) - Math.Abs(arr[y])) == diffSize)
                    {
                        br++;
                    }
                }
            }

            Console.WriteLine(br);

        }
    }
}
