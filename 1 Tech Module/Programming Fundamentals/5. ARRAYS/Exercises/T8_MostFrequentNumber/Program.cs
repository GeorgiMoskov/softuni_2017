using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostNum = arr[0];
            int mostNumCount = 1;
            
            for (int y = 0; y < arr.Length; y++)
            {
                int num = arr[y];
                int count = 1;

                for (int i = y+1; i < arr.Length; i++)
                {
                    if (num == arr[i])
                    {
                        count++;
                    }
                }

                if(count > mostNumCount)
                {
                    mostNumCount = count;
                    mostNum = num;
                }


            }

            Console.WriteLine(mostNum);
        }
    }
}
