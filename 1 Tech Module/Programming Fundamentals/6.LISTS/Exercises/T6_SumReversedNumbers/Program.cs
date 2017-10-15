using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {

                int numReversed = 0;
                int num = nums[i];

                while (num > 0)
                {
                    numReversed = numReversed * 10 + (num % 10);
                    num = num / 10;
                }

                sum += numReversed;

            }

            Console.WriteLine(sum);
        }
    }
}
