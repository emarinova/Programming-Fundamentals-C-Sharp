﻿

namespace p02_RectangleArea
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:F2}");

        }
    }
}
