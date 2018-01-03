using System;
using System.Numerics;

namespace Factorial
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
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialOfN = GetFactorial(n);
            Console.WriteLine(factorialOfN);
        }
    }
}
