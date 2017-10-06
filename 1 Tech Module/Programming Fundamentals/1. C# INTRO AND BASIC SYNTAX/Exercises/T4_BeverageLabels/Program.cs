using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var allEnergy = (volume * (double)energy) / 100;
            var allSugar = (volume * (double)sugar)/100;

            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars",allEnergy,allSugar);


        }
    }
}
