using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> usersAndDictOfIpsDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');

                string ip = inputArr[0];
                string name = inputArr[1];
                int duration = int.Parse(inputArr[2]);


                if (!usersAndDictOfIpsDuration.ContainsKey(name))
                {
                    usersAndDictOfIpsDuration.Add(name, new SortedDictionary<string, int>());
                }
                if (!usersAndDictOfIpsDuration[name].ContainsKey(ip))
                {
                    usersAndDictOfIpsDuration[name].Add(ip, 0);
                }
                usersAndDictOfIpsDuration[name][ip] += duration;


            }

            foreach (var userAndDictOfIpsDuration in usersAndDictOfIpsDuration)
            {
                Console.Write(userAndDictOfIpsDuration.Key + ": ");
                var sum = 0;
                List<string>ips = new List<string>();
                foreach (var ipAndDuration in userAndDictOfIpsDuration.Value)
                {
                    ips.Add(ipAndDuration.Key);
                    sum += ipAndDuration.Value;
                    
                }

                Console.Write(sum+" [");

                for(int i = 0; i < ips.Count; i++)
                {
                    if (i < ips.Count - 1)
                    {
                        Console.Write(ips[i] + ", ");
                    }
                    else
                    {
                        Console.Write(ips[i] + "]");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
