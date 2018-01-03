using System;

namespace FibonacciNumbers
{
    class Program
    {
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
           
        }
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            int numberInFibonacci = Fib(position);
            Console.WriteLine(numberInFibonacci);
        }
    }
}
