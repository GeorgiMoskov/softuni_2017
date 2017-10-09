using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            NearestPoint(x1,y1,x2,y2);

        }

        static void NearestPoint(double x1, double y1 , double x2, double y2)
        {
            double sumPoint1 = Math.Abs(x1) + Math.Abs(y1);
            double sumPoint2 = Math.Abs(x2) + Math.Abs(y2);

            if (sumPoint1 <= sumPoint2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);

            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }

        }
    }
}
