using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace T3_MInerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, int> resorses = new Dictionary<string, int>();

            while (true)
            {
                if (input != "stop")
                {
                    string key = input;
                    int value = int.Parse(Console.ReadLine());

                    if (!resorses.ContainsKey(key))
                    {
                        resorses[key] = value;
                    }
                    else
                    {
                        resorses[key] += value;
                    }

                }
                else
                {
                    foreach (var item in resorses)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                    return;
                }
                input = Console.ReadLine();
            }

        }
    }
}
