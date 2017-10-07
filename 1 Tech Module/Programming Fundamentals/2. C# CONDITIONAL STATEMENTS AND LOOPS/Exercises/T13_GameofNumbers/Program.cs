using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            var combCount = 0;
            var isComb = false;
            var lasti = 0;
            var lasty = 0;

            for(int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
            {
                for (int y = Math.Min(n, m); y <= Math.Max(n, m); y++)
                {
                    combCount++;
                    if(i+y == magicNum)
                    {
                        isComb = true;
                        lasti = i;
                        lasty = y;

                        
                    }
                }
            }

            if (isComb == true)
            {
                Console.WriteLine($"Number found! {lasti} + {lasty} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combCount} combinations - neither equals {magicNum}");
            }
           



        }
    }
}
