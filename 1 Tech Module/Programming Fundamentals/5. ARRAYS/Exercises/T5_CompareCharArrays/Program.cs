using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for(int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if(arr1[i] == arr2[i])
                {
                    continue;
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(String.Join("", arr2));
                    Console.WriteLine(String.Join("", arr1));
                    return;
                }
                else
                {
                    Console.WriteLine(String.Join("", arr1));
                    Console.WriteLine(String.Join("", arr2));
                    return;
                }
            }

            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(String.Join("", arr1));
                Console.WriteLine(String.Join("", arr2));
            }
            else
            {
                Console.WriteLine(String.Join("", arr2));
                Console.WriteLine(String.Join("", arr1));
            }

        }
    }
}
