﻿using System;
namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            int absolute = Math.Abs(number);
            Console.WriteLine($"The number is: {absolute}");

        }
    }
}
