using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i< n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }
            double minDistance = double.MaxValue;
            Point minP1 = new Point();
                Point minP2 = new Point();
            foreach (var p1 in points)
            {
                foreach (var p2 in points)
                {
                    if(p1!=p2)
                    {
                        double currentDistance = CalcDistance(p1, p2);
                        if(currentDistance<minDistance)
                        {
                            minDistance = currentDistance;
                            minP1 = p1;
                            minP2 = p2;
                        }
                    }

                }
            }
            Console.WriteLine(minDistance);
            Console.WriteLine("({0}, {1})", minP1.X, minP1.Y);
            Console.WriteLine("({0}, {1})", minP2.X, minP2.Y);
        }

        static Point ReadPoint()
        {
            int[] point = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p = new Point { X = point[0], Y = point[1] };
            return p;
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
