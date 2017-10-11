using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>allNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] comandNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> takenNumbers = new List<int>(allNumbers);

            takenNumbers.RemoveRange(comandNumbers[0], takenNumbers.Count() - comandNumbers[0]);
           
            takenNumbers.RemoveRange(0, comandNumbers[1]);
           
            if (takenNumbers.Contains(comandNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
