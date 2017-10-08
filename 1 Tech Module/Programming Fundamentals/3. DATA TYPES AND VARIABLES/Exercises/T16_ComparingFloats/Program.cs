using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 0.000001;

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if(Math.Max(num1,num2) - Math.Min(num1,num2) < epsilon)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
