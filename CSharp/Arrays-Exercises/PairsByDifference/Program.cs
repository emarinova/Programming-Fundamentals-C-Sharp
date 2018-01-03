using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dif = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] - input[j] == dif || input [i] - input[j] == -1 * dif)
                    {
                        counter++;
                    }
                }
            }
            
                Console.WriteLine(counter);
            
        }
    }
}
