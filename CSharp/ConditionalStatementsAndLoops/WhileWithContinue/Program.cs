using System;

namespace WhileWithContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)         // в java са съшите
                {                       //безкраен цикъл, програмата не може да компилира
                    continue;           //отговаря на рестарт, пропуска всичко надолу и започва while отначало
                }

                if (number == 0)
                {
                    break;               //прекъсва цикъла
                }
                double root = Math.Sqrt(number);
                Console.WriteLine(root);
            }
        }
    }
}
