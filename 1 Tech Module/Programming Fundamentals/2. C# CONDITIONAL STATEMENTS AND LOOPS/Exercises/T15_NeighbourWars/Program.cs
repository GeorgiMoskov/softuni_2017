using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDmg = int.Parse(Console.ReadLine());
            var goshoDmg = int.Parse(Console.ReadLine());
            var peshohp = 100;
            var goshohp = 100;
            var round = 1;

            while (true)
            {
                if(round%2 == 1)
                {
                    goshohp -= peshoDmg;
                        if (goshohp <= 0)
                        {
                            Console.WriteLine("Pesho won in {0}th round.", round);
                            break;
                        }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.",goshohp);
                }
                else
                {
                    peshohp -= goshoDmg;
                        if (peshohp <= 0)
                        {
                          Console.WriteLine("Gosho won in {0}th round.", round);
                           break;
                        }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.",peshohp);
                }


                if (round % 3 == 0)
                {
                    goshohp += 10;
                    peshohp += 10;
                }

                round++;

            }

        }
    }
}
