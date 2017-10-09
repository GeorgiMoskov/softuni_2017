using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            Console.WriteLine("{0:F2}",AreaCalculation(figureType));

        }

        static double AreaCalculation(string figureType)
        {
            switch (figureType)
            {
                case "triangle":
                    return AreaCalcTriangle();
                case "square":
                    return AreaCalcSquare();
                case "rectangle":
                    return AreaCalcRectangle();
                case "circle":
                    return AreaCalcCircle();

            }


            return 0;
        }

        static double AreaCalcTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (side * height) / 2;
            return area;
        }

        static double AreaCalcSquare()
        {
            double side = double.Parse(Console.ReadLine());
            double area = Math.Pow(side, 2);
            return area;
        }

        static double AreaCalcRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            return area;
        }

        static double AreaCalcCircle()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
