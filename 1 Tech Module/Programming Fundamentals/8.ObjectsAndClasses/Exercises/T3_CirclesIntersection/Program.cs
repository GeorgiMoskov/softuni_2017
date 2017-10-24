using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_CirclesIntersection
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }


    class Program
    {
        public static string Intersect(Circle c1, Circle c2)
        {
            int x1 = c1.Center.X;
            int y1 = c1.Center.Y;
            int x2 = c2.Center.X;
            int y2 = c2.Center.Y;

            double distance = Math.Sqrt( Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) );

            if(distance <= c1.Radius + c2.Radius)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        static void Main(string[] args)
        {

            int[] arrInput1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point center1 = new Point()
            {
                X = arrInput1[0],
                Y = arrInput1[1]
            };

            Circle circle1 = new Circle(){
                Center = center1,
                Radius = arrInput1[2]
            };

            int[] arrInput2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point center2 = new Point()
            {
                X = arrInput2[0],
                Y = arrInput2[1]
            };

            Circle circle2 = new Circle()
            {
                Center = center2,
                Radius = arrInput2[2]
            };

            Console.WriteLine(Intersect(circle1, circle2));




        }
    }
}
