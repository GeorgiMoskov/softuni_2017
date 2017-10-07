using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studioPricePerNight = 0.0;
            var doublePricePerNight = 0.0;
            var suitePricePerNight = 0.0;
            var studioPriceTotal = 0.0;
            var doublePriceTotal = 0.0;
            var suitePriceTotal = 0.0;

            switch (month)
            {
                case "May":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;

                    studioPriceTotal = studioPricePerNight * nights;
                    doublePriceTotal = doublePricePerNight * nights;
                    suitePriceTotal = suitePricePerNight * nights;

                    if (nights > 7)
                    {
                        studioPriceTotal = studioPriceTotal - (studioPriceTotal / 100 *5);
                    }
                    
                    break;

                case "October":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;

                    studioPriceTotal = studioPricePerNight * nights;
                    doublePriceTotal = doublePricePerNight * nights;
                    suitePriceTotal = suitePricePerNight * nights;

                    if (nights > 7)
                    {
                        studioPriceTotal = studioPriceTotal - studioPricePerNight;
                        studioPriceTotal = studioPriceTotal - (studioPriceTotal / 100 * 5);
                        
                    }

                    break;

                case "June":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;

                    studioPriceTotal = studioPricePerNight * nights;
                    doublePriceTotal = doublePricePerNight * nights;
                    suitePriceTotal = suitePricePerNight * nights;

                    if (nights > 14)
                    {
                        doublePriceTotal = doublePriceTotal - (doublePriceTotal / 100 * 10);
                    }

                    break;

                case "September":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;

                    studioPriceTotal = studioPricePerNight * nights;
                    doublePriceTotal = doublePricePerNight * nights;
                    suitePriceTotal = suitePricePerNight * nights;

                    if (nights > 7)
                    {
                        studioPriceTotal = studioPriceTotal - studioPricePerNight;
                    }


                    if (nights > 14)
                    {
                        doublePriceTotal = doublePriceTotal - (doublePriceTotal / 100 * 10);
                    }

                    break;

                case "July":
                case "August":
                case "December":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;

                    studioPriceTotal = studioPricePerNight * nights;
                    doublePriceTotal = doublePricePerNight * nights;
                    suitePriceTotal = suitePricePerNight * nights;


                    if (nights > 14)
                    {
                        suitePriceTotal = suitePriceTotal - (suitePriceTotal / 100 * 15);
                    }

                    break;
            }

            Console.WriteLine("Studio: {0:F2} lv.", studioPriceTotal);
            Console.WriteLine("Double: {0:F2} lv.", doublePriceTotal);
            Console.WriteLine("Suite: {0:F2} lv.", suitePriceTotal);


        }
    }
}
