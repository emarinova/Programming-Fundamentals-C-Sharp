using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] circle1Data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] circle2Data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle1 = new Circle { Center = new Point { X = circle1Data[0], Y = circle1Data[1] }, Radius = circle1Data[2] };
            Circle circle2 = new Circle { Center = new Point { X = circle2Data[0], Y = circle2Data[1] }, Radius = circle2Data[2] };
            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double d = CalcDistance(c1.Center, c2.Center);
            if (d <= c1.Radius + c2.Radius)
                return true;
            else
                return false;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }
}
