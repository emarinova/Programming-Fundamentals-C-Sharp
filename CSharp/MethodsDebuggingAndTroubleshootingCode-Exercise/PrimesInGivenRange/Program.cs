using System;
using System.Collections.Generic;
namespace PrimesInGivenRange
{
    class Program
    {
        static bool isPrime(long n)
        {
            bool isIt = true;
            if (n == 0 || n == 1)
            {
                isIt = false;
            }
            else if (n != 2)
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isIt = false;
                    }
                }
            }
            return isIt;
        }
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            IList<long> primeNumbers = new List<long>();
            if (second >= first)
            {
                for (long i = first; i <= second; i++)
                {
                    if (isPrime(i))
                    {
                        primeNumbers.Add(i);
                    }
                }

                Console.WriteLine(String.Join(", ", primeNumbers));
            }
        }
    }
}
