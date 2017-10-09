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
            double lineOneX1 = double.Parse(Console.ReadLine());
            double lineOneY1 = double.Parse(Console.ReadLine());
            double lineOneX2 = double.Parse(Console.ReadLine());
            double lineOneY2 = double.Parse(Console.ReadLine());
            double lineTwoX1 = double.Parse(Console.ReadLine());
            double lineTwoY1 = double.Parse(Console.ReadLine());
            double lineTwoX2 = double.Parse(Console.ReadLine());
            double lineTwoY2 = double.Parse(Console.ReadLine());

            LongerLine(lineOneX1, lineOneY1, lineOneX2, lineOneY2, lineTwoX1, lineTwoY1, lineTwoX2, lineTwoY2);

        }

        static void LongerLine(double lineOneX1, double lineOneY1, double lineOneX2, double lineOneY2, double lineTwoX1, double lineTwoY1, double lineTwoX2, double lineTwoY2)
        {
            double lineOneLength = Math.Sqrt( Math.Pow((lineOneX2 - lineOneX1),2) + Math.Pow((lineOneY2 - lineOneY1), 2));
            double lineTwoLength = Math.Sqrt(Math.Pow((lineTwoX2 - lineTwoX1), 2) + Math.Pow((lineTwoY2 - lineTwoY1), 2));
            
            if(lineOneLength >= lineTwoLength)
            {
                double sumPoint1 = Math.Abs(lineOneX1) + Math.Abs(lineOneY1);
                double sumPoint2 = Math.Abs(lineOneX2) + Math.Abs(lineOneY2);
                if (sumPoint1 <= sumPoint2)
                {
                    Console.Write("({0}, {1})", lineOneX1, lineOneY1);
                    Console.Write("({0}, {1})", lineOneX2, lineOneY2);

                }
                else
                {
                    Console.Write("({0}, {1})", lineOneX2, lineOneY2);
                    Console.Write("({0}, {1})", lineOneX1, lineOneY1);
                }

            }
            else
            {
                double sumPoint1 = Math.Abs(lineTwoX1) + Math.Abs(lineTwoY1);
                double sumPoint2 = Math.Abs(lineTwoX2) + Math.Abs(lineTwoY2);
                if (sumPoint1 <= sumPoint2)
                {
                    Console.Write("({0}, {1})", lineTwoX1, lineTwoY1);
                    Console.Write("({0}, {1})", lineTwoX2, lineTwoY2);

                }
                else
                {
                    Console.Write("({0}, {1})", lineTwoX2, lineTwoY2);
                    Console.Write("({0}, {1})", lineTwoX1, lineTwoY1);
                }

            }
        }

    }
}
