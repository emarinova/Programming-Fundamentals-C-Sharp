using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            // int odd = 1; po-dobre e taka, izwyn for -a
            for (int i = 0, odd = 1; i < n; i++)
            {
                sum += odd;
                Console.WriteLine(odd);
                odd += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
