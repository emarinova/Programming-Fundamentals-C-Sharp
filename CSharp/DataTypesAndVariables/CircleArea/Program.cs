using System;
namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            // area = Math.Round(area, 12);
            Console.WriteLine($"{area:F12}");
        }
    }
}
