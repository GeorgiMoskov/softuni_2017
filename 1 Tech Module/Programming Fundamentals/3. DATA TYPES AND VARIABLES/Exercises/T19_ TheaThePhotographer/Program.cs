using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace T19__TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long allPics = long.Parse(Console.ReadLine());
            long secondsToFilterOnePic = long.Parse(Console.ReadLine());
            long filterPercentage = long.Parse(Console.ReadLine());
            long secondsToUpload = long.Parse(Console.ReadLine());


            long secondsTakenToFilter = allPics * secondsToFilterOnePic;
            long secondsTakenToUpload = ((long)Math.Ceiling((allPics / 100.0) * filterPercentage))*secondsToUpload;
            long takenSecondsForEveryThing = secondsTakenToFilter + secondsTakenToUpload;
            long days = 0;
            long hours = 0;
            long minutes = 0;
            long seconds = 0;

            seconds = takenSecondsForEveryThing % 60;
            long leftInSeconds = takenSecondsForEveryThing - seconds;

            minutes = (leftInSeconds / 60) % 60;
            long leftInMinutes = (leftInSeconds / 60) - minutes;

            hours = (leftInMinutes / 60) % 24;
            long leftInHours = (leftInMinutes / 60) - hours;

            days = leftInHours / 24;




            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

        }
    }
}
