using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    
    class Program
    {
        static void PrintTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            double area = side * heigh / 2;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            double area = width * heigh;
            Console.WriteLine($"{area:F2}");
        }

        static void PrintCircleArea()
        {
            double rad = double.Parse(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine($"{area:F2}");
        }

        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    PrintTriangleArea();
                    break;
                case "square":
                    PrintSquareArea();
                    break;
                case "rectangle":
                    PrintRectangleArea();
                    break;
                case "circle":
                    PrintCircleArea();
                    break;
                default:
                    break;
            }
        }
    }
}
