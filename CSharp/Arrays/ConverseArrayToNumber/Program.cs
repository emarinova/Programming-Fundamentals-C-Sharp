using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (input.Length>1)
            {
                input = Condense(input);
            }
            Console.WriteLine(input[0]);
        }

        static int[] Condense(int[] numbers)
        {
            int[] condensed = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                condensed[i] = numbers[i] + numbers[i+1];
            }
            numbers = new int[condensed.Length];
            for (int i = 0; i< condensed.Length; i++)
            {
                numbers[i] = condensed[i];
            }
            return numbers;
        }
    }
}
