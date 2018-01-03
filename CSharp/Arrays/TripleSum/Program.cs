using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isThere = false;
            for (int a = 0; a < numbers.Length-1; a++)
            {
                for (int b = a+1; b < numbers.Length; b++)
                {
                    int sum = numbers[a] + numbers[b];
                    int index = Array.IndexOf(numbers, sum);
                    if (index > -1)
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[index]}");
                        isThere = true;
                    }
                }
            }
            if (!isThere)
            {
                Console.WriteLine("No");
            }

        }
    }
}
