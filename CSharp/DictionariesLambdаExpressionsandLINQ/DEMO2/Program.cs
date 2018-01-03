using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());
            var nums = Console.ReadLine().Split().Select(number => Math.Round(double.Parse(number)));
            nums.OrderBy(num => Math.Abs(num));

            //var nums = Console.ReadLine().Split().Select(number => Math.Round(double.Parse(number))); // дългата версия
           
           

            string[] words = new string[] { "coffee", "vodka", "main" };
            var orderedByLastLetter = words.OrderBy(w => w[w.Length - 1]).ThenBy(w => w.Length);
            Console.WriteLine(String.Join(" ",orderedByLastLetter));

           
        }
    }
}
