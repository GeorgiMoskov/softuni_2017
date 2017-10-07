using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ChooseDrink_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantities = int.Parse(Console.ReadLine());
            var drink = "Tea";
            var price = 1.20;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.70;
            }

            price = quantities * price;
            Console.WriteLine("The {0} has to pay {1:F2}.",profession,price);
            
        }
    }
}
