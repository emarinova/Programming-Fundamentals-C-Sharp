using System;

namespace CenterPoint
{
    class Program
    {
        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double side1 = Math.Abs(x1 - x2);
            double side2 = Math.Abs(y1 - y2);
            double distance = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            return distance;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distance1 = DistanceBetweenTwoPoints(0, 0, x1, y1);
            double distance2 = DistanceBetweenTwoPoints(0, 0, x2, y2);
            if (distance1<distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }
    }
}
