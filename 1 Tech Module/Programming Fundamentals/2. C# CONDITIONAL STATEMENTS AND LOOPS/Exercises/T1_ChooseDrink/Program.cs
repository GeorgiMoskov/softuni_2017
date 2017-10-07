using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var drink = "Tea";

            if(profession == "Athlete")
            {
                drink = "Water";
            }
            else if(profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if(profession == "SoftUni Student")
            {
                drink = "Beer";
            }

            Console.WriteLine(drink);
        }
    }
}
