using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
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
            Point p1 = new Point();
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            p1.X = coordinates[0];
            p1.Y = coordinates[1];

            Point p2 = new Point();
            int[] coordinates2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            p2.X = coordinates2[0];
            p2.Y = coordinates2[1];

            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            Console.WriteLine($"{distance:F3}");
        }
    }
}
