using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsCount = int.Parse(Console.ReadLine());
            var calories = 0;

            for(var i = 0; i < productsCount; i++)
            {
                var product = Console.ReadLine();
                product = product.ToLower();

                switch (product)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;

                }
                
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
