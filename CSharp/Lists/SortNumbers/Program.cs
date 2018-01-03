﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse).ToList());
            numbers.Sort();
            Console.WriteLine(String.Join(" <= ",numbers));
        }
    }
}
