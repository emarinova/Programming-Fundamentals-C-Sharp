using System;

namespace HelloName
{
    class Program
    {
        static void PrintsHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintsHelloName(name);
        }
    }
}
