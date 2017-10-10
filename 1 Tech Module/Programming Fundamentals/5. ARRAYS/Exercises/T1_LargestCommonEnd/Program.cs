using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int loopEnd = Math.Min((arr1.Length-1),(arr2.Length-1));

            int countLeftSide = 0;

            for(int i = 0; i <= loopEnd; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    countLeftSide++;
                }
            }

            int countRightSide = 0;

            for (int i = 0; i <= loopEnd; i++)
            {
                if (arr1[arr1.Length-i-1] == arr2[arr2.Length-i-1])
                {
                    countRightSide++;
                }
            }

            Console.WriteLine(Math.Max(countLeftSide,countRightSide));



        }
    }
}
