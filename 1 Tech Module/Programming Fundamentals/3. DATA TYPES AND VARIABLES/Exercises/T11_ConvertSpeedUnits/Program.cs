using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;

            float metersPerSecond = distance / timeInSeconds;
            float kmsPerHour = (distance / 1000) / (timeInSeconds / 60 /60);
            float miles = distance / 1609;
            float milesPerHour = miles / (timeInSeconds / 3600);

            Console.WriteLine("{0:g7}",metersPerSecond);
            Console.WriteLine("{0:g7}", kmsPerHour);
            Console.WriteLine("{0:g7}", milesPerHour);
        }
    }
}
