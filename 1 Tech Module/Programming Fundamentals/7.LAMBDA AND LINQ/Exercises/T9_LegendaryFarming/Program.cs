using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, int> junkMaterialsAndQuantity = new SortedDictionary<string, int>();
            SortedDictionary<string, int> keyMaterialsAndQuantity = new SortedDictionary<string, int>();
            keyMaterialsAndQuantity["shards"] = 0;
            keyMaterialsAndQuantity["fragments"] = 0;
            keyMaterialsAndQuantity["motes"] = 0;

            bool log = false;
            while (true)
            {
                List<string> inputList = Console.ReadLine().ToLower().Split(' ').ToList();


                for (int i = 0; i < inputList.Count; i += 2)
                {
                    if (keyMaterialsAndQuantity.ContainsKey(inputList[i + 1]))
                    {
                        keyMaterialsAndQuantity[inputList[i + 1]] += int.Parse(inputList[i]);
                    }
                    else
                    {
                        if (!junkMaterialsAndQuantity.ContainsKey(inputList[i+1]))
                        {
                            junkMaterialsAndQuantity[inputList[i + 1]] = int.Parse(inputList[i]);
                        }
                        else
                        {
                            junkMaterialsAndQuantity[inputList[i + 1]] += int.Parse(inputList[i]);
                        }


                    }

                    if (keyMaterialsAndQuantity["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMaterialsAndQuantity["shards"] -= 250;
                        log = true;
                        break;
                    }
                    else if (keyMaterialsAndQuantity["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        keyMaterialsAndQuantity["fragments"] -= 250;
                        log = true;
                        break;
                    }
                    else if (keyMaterialsAndQuantity["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMaterialsAndQuantity["motes"] -= 250;
                        log = true;
                        break;
                    }

                }

                if (log == true)
                {
                    break;
                }




            }

            foreach (var keyMaterialAndQuantity in keyMaterialsAndQuantity.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0}: {1}", keyMaterialAndQuantity.Key.ToLower(), keyMaterialAndQuantity.Value);
            }

            foreach (var junkMaterialAndQuantity in junkMaterialsAndQuantity)
            {
                Console.WriteLine("{0}: {1}", junkMaterialAndQuantity.Key, junkMaterialAndQuantity.Value);
            }

        }
    }
}
