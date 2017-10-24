using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var powers = new Dictionary<string, int>()
            {
                {"2",2},
                {"3",3},
                {"4",4},
                {"5",5},
                {"6",6},
                {"7",7},
                {"8",8},
                {"9",9},
                {"10",10},
                {"J",11},
                {"Q",12},
                {"K",13},
                {"A",14}
            };

            var multipliers = new Dictionary<string, int>()
            {
                {"S",4 },
                {"H",3 },
                {"D",2 },
                {"C",1 }
            };

            
            var playersNamesAndHands = new Dictionary<string, List<string>>();

            while (true)
            {

                string inputStr = Console.ReadLine();

                if (inputStr != "JOKER")
                {

                    string name = inputStr.Substring(0, inputStr.IndexOf(':'));
                    inputStr = inputStr.Substring(inputStr.IndexOf(':') + 1, inputStr.Length - (inputStr.IndexOf(':') + 1));
                    string[] input = inputStr.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                    if (!playersNamesAndHands.ContainsKey(name))
                    {
                        playersNamesAndHands[name] = new List<string>();
                    }

                    for(int i = 0; i < input.Length; i++)
                    {
                        if (!playersNamesAndHands[name].Contains(input[i]))
                        {
                            playersNamesAndHands[name].Add(input[i]);
                        }
                    }


                }
                else
                {
                    foreach (var playerCards in playersNamesAndHands)
                    {

                        
                        int sum = 0;
                        for (int i = 0; i < playerCards.Value.Count; i++)
                        {

                            string power = playerCards.Value[i].Substring(0, playerCards.Value[i].Length - 1);
                            string multi = playerCards.Value[i].Substring(playerCards.Value[i].Length - 1,1);

                            sum += powers[power] * multipliers[multi];

                        }

                        Console.WriteLine("{0}: {1}", playerCards.Key, sum);



                    }



                }
            }



        }
    }
}
