using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T1_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = File.ReadAllText("input.txt")
                .Split()
                .Select(x=>int.Parse(x))
                .ToArray();

            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            foreach (var inp in input)
            {
                if (numsCount.ContainsKey(inp))
                {
                    numsCount[inp] += 1;
                }
                else
                {
                    numsCount[inp] = 1;
                }
            }

           string output = numsCount.FirstOrDefault(x => x.Value == numsCount.Values.Max() ).Key.ToString() ;
            File.WriteAllText("output.txt", output);

        }
    }
}
