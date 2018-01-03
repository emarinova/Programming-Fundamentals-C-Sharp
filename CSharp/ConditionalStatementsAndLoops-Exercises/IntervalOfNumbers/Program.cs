using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n2<n1)
            {
                int x = n1;
                n1 = n2;
                n2 = x;
            }
            for (int i = n1; i<= n2; i++)
                Console.WriteLine(i);
        }
    }
}
