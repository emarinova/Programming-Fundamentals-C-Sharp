using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());
            if (from<=10)
                for (int i = from; i <= 10; i++)
                {
                    Console.WriteLine($"{integer} X {i} = {integer*i}");
                }
            else Console.WriteLine($"{integer} X {from} = {integer*from}");
        }
    }
}
