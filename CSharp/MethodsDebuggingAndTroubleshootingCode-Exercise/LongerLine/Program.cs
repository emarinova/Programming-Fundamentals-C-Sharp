using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double side1 = Math.Abs(x1 - x2);
            double side2 = Math.Abs(y1 - y2);
            double distance = Math.Sqrt(side1 * side1 + side2 * side2);
            return distance;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1 = DistanceBetweenTwoPoints(x1, y1, x2, y2);
            double line2 = DistanceBetweenTwoPoints(x3, y3, x4, y4);

            if (line1>=line2)
            {
                double distanceToCenterPoint1 = DistanceBetweenTwoPoints(0, 0, x1, y1);
                double distanceToCenterPoint2 = DistanceBetweenTwoPoints(0, 0, x2, y2);
                if (distanceToCenterPoint1 <= distanceToCenterPoint2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double distanceToCenterPoint3 = DistanceBetweenTwoPoints(0, 0, x3, y3);
                double distanceToCenterPoint4 = DistanceBetweenTwoPoints(0, 0, x4, y4);
                if (distanceToCenterPoint3 <= distanceToCenterPoint4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
