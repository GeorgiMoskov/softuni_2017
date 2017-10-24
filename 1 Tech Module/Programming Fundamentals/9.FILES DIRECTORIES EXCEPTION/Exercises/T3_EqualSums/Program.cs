using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T3_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            int[] input = File.ReadAllText("input.txt").Split().Select(x=>int.Parse(x)).ToArray();

            if (input.Length == 1)
            {
                File.WriteAllText("output.txt", "0");
                return;
            }

            int i = 0;
            int y = input.Length - 1;
            int iSum = input[i];
            int ySum = input[y];


            while (y - i > 2)
            {
                if (iSum <= ySum)
                {
                    i++;
                    iSum += input[i];
                    
                }
                else
                {
                    y--;
                    ySum += input[y];
                   
                }

            }

            if(iSum == ySum)
            {
                File.WriteAllText("output.txt", (i+1).ToString());
            }
            else
            {
                File.WriteAllText("output.txt", "no");
            }

        }
    }
}
