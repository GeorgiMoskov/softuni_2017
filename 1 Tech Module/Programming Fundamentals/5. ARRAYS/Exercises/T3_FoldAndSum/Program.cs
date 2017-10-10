using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrAll = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arrFirstLine = new int[arrAll.Length / 2];


            for(int i = 0; i <= (arrAll.Length / 4) - 1; i++)
            {
                arrFirstLine[i] = arrAll[(arrAll.Length / 4) - 1 - i];
            }

            for(int i= 0;i <= (arrAll.Length / 4) - 1; i++ )
            {
                arrFirstLine[(arrFirstLine.Length / 2) + i] = arrAll[arrAll.Length - 1 - i];
            }


            int[]arrSecondLine = new int[arrAll.Length / 2];

            int[]arrSum = new int[arrAll.Length / 2];

            for (int i =0; i<= arrSecondLine.Length-1; i++)
            {
                arrSecondLine[i] = arrAll[(arrAll.Length / 4) + i];

                arrSum[i] = arrFirstLine[i] + arrSecondLine[i];
            }

            for(int i = 0; i <= arrSum.Length - 1; i++)
            {
                Console.Write("{0} ", arrSum[i]);
            }

            


        }
    }
}
