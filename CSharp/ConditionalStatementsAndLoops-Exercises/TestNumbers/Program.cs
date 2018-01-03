using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int i = n1; i >= 1; i--)
            {
                for (int j = 1; j <= n2; j++)
                {
                    count++;
                    sum = sum + 3 * (i * j);
                    if (sum>=max)
                    {
                        Console.WriteLine($"{count} combinations\r\nSum: {sum} >= {max}");
                        break;
                    }
                }
                if (sum>=max)
                {
                    break;
                }
            }
            if (sum < max)
            {

                Console.WriteLine($"{count} combinations\r\nSum: {sum}");
            }
        }
    }
}
