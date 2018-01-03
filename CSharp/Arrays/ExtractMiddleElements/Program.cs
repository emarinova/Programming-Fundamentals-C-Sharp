using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers.Length;
            if (n == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine($"{{ {numbers[n/2 -1]}, {numbers[n/2]}, {numbers[n/2 +1]} }}");
            }
            else if (n%2 == 0)
            {
                Console.WriteLine($"{{ {numbers[n/2-1]}, {numbers[n/2]} }}");
            }
        }
    }
}
