using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            string typeOfCalculation = Console.ReadLine();

            double answer = 0;
            switch (typeOfCalculation)
            {
                case "face":
                    answer = FaceDiagonals(sideSize);
                    break;
                case "space":
                    answer = SpaceDiagonals(sideSize);
                    break;
                case "volume":
                    answer = Volume(sideSize);
                    break;
                case "area":
                    answer = SurfaceArea(sideSize);
                    break;
                default:
                    return;
            }

            Console.WriteLine("{0:F2}",answer);
        }

        static double FaceDiagonals(double sideSize)
        {
            double answer = Math.Sqrt(2 * Math.Pow(sideSize, 2));
            return answer;
        }

        static double SpaceDiagonals(double sideSize)
        {
            double answer = Math.Sqrt(3 * Math.Pow(sideSize, 2));
            return answer;
        }

        static double Volume(double sideSize)
        {
            double answer = Math.Pow(sideSize, 3);
            return answer;
        }

        static double SurfaceArea(double sideSize)
        {
            double answer = 6 * (Math.Pow(sideSize, 2));
            return answer;
        }
    }
}
