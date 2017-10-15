using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> comandsAndParameters = Console.ReadLine().Split(' ').ToList();

                switch (comandsAndParameters[0])
                {
                    case "add":
                        nums.Insert(int.Parse(comandsAndParameters[1]), int.Parse(comandsAndParameters[2]));
                        break;
                    case "addMany":
                        List<string> paramStr = new List<string>(comandsAndParameters);
                        paramStr.RemoveAt(0);
                        paramStr.RemoveAt(0);
                        List<int> paramInts = new List<int>(paramStr.Select(int.Parse).ToList());
                        nums.InsertRange(int.Parse(comandsAndParameters[1]), paramInts);
                        break;
                    case "contains":
                        if (nums.Contains(int.Parse(comandsAndParameters[1])))
                        {
                            for(int i = 0; i < nums.Count; i++)
                            {
                                if(nums[i] == int.Parse(comandsAndParameters[1]) )
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }

                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(comandsAndParameters[1]));
                        break;
                    case "shift":
                        List<int> tempNums = new List<int>(nums);

                        for (int i = 0; i < nums.Count; i++)
                        {
                            nums[i] = tempNums[(i + int.Parse(comandsAndParameters[1])) % (nums.Count)];

                        }
                        break;
                    case "sumPairs":
                        for (int i = 0; i < nums.Count-1; i++)
                        {
                            nums[i+1] = nums[i] + nums[i + 1];
                            nums.RemoveAt(i);
                        }
                        break;
                    case "print":
                        Console.Write("[");

                        for (int i = 0; i < nums.Count - 1; i++)
                        {
                            Console.Write("{0}, ", nums[i]);
                        }
                        Console.Write("{0}]", nums[nums.Count - 1]);
                        return;
                        
                }
            }

        }
    }
}
