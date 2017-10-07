using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "";
            var br = 0;
            while (true)
            {
                str = Console.ReadLine();

                if(str == "Bake!")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Adding ingredient {0}.", str);
                    br++;
                }

            }

            Console.WriteLine("Preparing cake with {0} ingredients.",br);
        }
    }
}
