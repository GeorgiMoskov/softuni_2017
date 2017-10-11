using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List <string> comandAndValues = Console.ReadLine().Split(' ').ToList();

                int arg1 = 0;
                int arg2 =0;
                switch (comandAndValues[0])
                {
                    case "Delete":
                        arg1 = int.Parse(comandAndValues[1]); 
                        nums.RemoveAll(item => item == arg1);
                        break;
                    case "Insert":
                        arg1 = int.Parse(comandAndValues[1]);
                        arg2 = int.Parse(comandAndValues[2]);
                        nums.Insert(arg2, arg1);
                        break;
                    case "Odd":
                        nums.RemoveAll(item => item % 2 == 0);
                        Console.WriteLine(String.Join(" ", nums));
                        return;
                    case "Even":
                        nums.RemoveAll(item => item % 2 != 0);
                        Console.WriteLine(String.Join(" ", nums));
                        return;

                }

            }

        }
    }
}
