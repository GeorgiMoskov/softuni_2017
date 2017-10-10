using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestStart = 0;
            int longestEnd = 0;
            int element = arr[0];

            int start = 0;
            int end = 0;

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    end = i;

                    if(end - start > longestEnd - longestStart)
                    {
                        longestEnd = end;
                        longestStart = start;
                    }
                }
                else
                {
                    start = i;
                    end = i;
                    element = arr[i];
                }
            }

            for (int i = longestStart; i <= longestEnd; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
    }
}
