using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse).ToList());
            bool counter = false;
            do
            {
                counter = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter = true;
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
            }
            while (counter);
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
