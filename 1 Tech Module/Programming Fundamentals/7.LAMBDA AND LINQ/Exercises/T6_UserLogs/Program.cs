using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> usersAndIpCount = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string inputLine = Console.ReadLine();


                if (inputLine != "end")
                {
                    string ip = inputLine.Substring(3, inputLine.IndexOf(' ') - 3);


                    string user = inputLine.Substring(inputLine.IndexOf("user=") + 5, inputLine.Length - (inputLine.IndexOf("user=") + 5));

                    if (!usersAndIpCount.ContainsKey(user))
                    {
                        usersAndIpCount.Add(user, new Dictionary<string, int>());
                        usersAndIpCount[user][ip] = 1;
                    }
                    else
                    {
                        if (!usersAndIpCount[user].ContainsKey(ip))
                        {
                            usersAndIpCount[user].Add(ip, 1);
                        }
                        else
                        {
                            usersAndIpCount[user][ip] += 1;
                        }
                    }

                }
                else
                {

                    foreach (var userAndIpCount in usersAndIpCount)
                    {
                        Console.WriteLine(userAndIpCount.Key + ":");

                        List<string> strCurentIpAndCount = new List<string>();

                        foreach (var ipAndCount in usersAndIpCount[userAndIpCount.Key])
                        {
                            strCurentIpAndCount.Add(" " + ipAndCount.Key + " => " + ipAndCount.Value);
                        }

                        for (int i = 0; i < strCurentIpAndCount.Count; i++)
                        {

                            if (i != strCurentIpAndCount.Count - 1)
                            {
                                Console.Write(strCurentIpAndCount[i] + ",");
                            }
                            else
                            {
                                Console.Write(strCurentIpAndCount[i] + ".");
                                Console.WriteLine();
                            }
                        }

                    }

                    break;
                }
            }

        }
    }
}
