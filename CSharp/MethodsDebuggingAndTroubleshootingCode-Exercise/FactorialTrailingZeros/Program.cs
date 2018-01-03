using System;
using System.Numerics;

namespace FactorialTrailingZeros
{
    class Program
    {
        static BigInteger GetFactorial(BigInteger number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * GetFactorial(number - 1);
            }
        }

        static int CountZeros(BigInteger number)
        {
            int counter = 0;
            while (true)
            {
                if (number % 10 == 0)
                {
                    counter++;
                    number /= 10;
                }
                else
                {
                    return counter;
                }
            }
            return counter;
            

        }

        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialOfNumber = GetFactorial(number);
            int zeros = CountZeros(factorialOfNumber);
            Console.WriteLine(zeros);
        }
    }
}
