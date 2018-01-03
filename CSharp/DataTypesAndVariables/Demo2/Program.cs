using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = 2000000000;
            int multiplied = 1000;
            long result = multiplied * (long)multiplier;

            //Console.WriteLine(2000000000L * 1000);

            Console.WriteLine(result);
        }
    }
}
