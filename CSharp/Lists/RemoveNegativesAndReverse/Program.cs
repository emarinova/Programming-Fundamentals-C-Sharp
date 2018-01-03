using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            List<int> results = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if(numbers[i]>=0)
                {
                    results.Add(numbers[i]);
                }
            }
            Console.WriteLine(String.Join(" ",results));
            if (results.Count == 0) Console.WriteLine("empty");

            
        }
    }
}
