using System;

namespace PrimeChecker
{
    class Program
    {
        static void isPrime(long n)
        {
            bool isIt = true;
            if (n==0 || n==1)
            {
                isIt = false;
            }
            else if ( n != 2)
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isIt = false;
                    }
                }
            }
            Console.WriteLine(isIt);
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            isPrime(number);
        }
    }
}
