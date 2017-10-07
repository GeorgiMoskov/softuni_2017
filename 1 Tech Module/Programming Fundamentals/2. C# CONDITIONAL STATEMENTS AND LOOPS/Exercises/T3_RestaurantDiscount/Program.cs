using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var discount = 0;
            var hall = "";
            var packagePrice = 0;
            var hallPrice = 0;
            var pricePerPerson = 0D;

            switch (package)
            {
                case "Normal":
                    discount = 5;
                    packagePrice = 500;
                    break;
                case "Gold":
                    discount = 10;
                    packagePrice = 750;
                    break;
                case "Platinum":
                    discount = 15;
                    packagePrice = 1000;
                    break;
                default:
                    break;        
            }

            if(groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
            }
            else if(groupSize<=100)
            {
                hall = "Terrace";
                hallPrice = 5000;
            }
            else if(groupSize<=120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                pricePerPerson = ((hallPrice + packagePrice) - (hallPrice + packagePrice) / (double)100 * discount) / groupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            



        }
    }
}
