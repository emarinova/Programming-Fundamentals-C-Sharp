using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = bool.Parse(Console.ReadLine());
            if (a)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
