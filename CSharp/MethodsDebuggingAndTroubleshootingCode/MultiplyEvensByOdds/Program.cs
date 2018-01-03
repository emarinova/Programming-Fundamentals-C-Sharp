using System;
namespace MultiplyEvensByOdds
{
    class Program
    {
        static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int digit = n % 10;
                if (digit%2==0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOdds(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int sumOfEvens = GetSumOfEvens(n);
            int sumOfOdds = GetSumOfOdds(n);
            int result = sumOfEvens * sumOfOdds;
            Console.WriteLine(result);
        }
    }
}
