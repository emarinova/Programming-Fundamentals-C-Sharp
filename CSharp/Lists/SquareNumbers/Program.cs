using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            List<int> squares = new List<int>();
            double root;

            foreach (var number in numbers)
            {
                for (int i = 1; i <= number; i++)
                {
                    if(i * i == number)
                    {
                        squares.Add(number);
                        break;
                    }
                }
            }

            squares.Sort();
            for(int i = squares.Count - 1; i >= 0; i--)
            {
                Console.Write(squares[i] + " ");
            }
        }
    }
}
