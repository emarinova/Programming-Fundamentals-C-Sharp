using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                result += x[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversedNumber = Reverse(number);
            Console.WriteLine(reversedNumber);
        }
    }
}
