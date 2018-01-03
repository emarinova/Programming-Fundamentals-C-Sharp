using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = ReverseDigitsOfNum(numbers[i]);
            }
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }

        static int ReverseDigitsOfNum(int num)
        {
            int reversed = 0;
            while (num > 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return reversed;
        }
    }
}
