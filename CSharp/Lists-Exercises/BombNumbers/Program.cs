using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            int[] bombNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (input.IndexOf(bombNumber[0]) >= 0)
            {
                int i = input.IndexOf(bombNumber[0]);

                int numsToRemove;
                int startPosition;
                if (i - bombNumber[1] >= 0)
                {
                    numsToRemove = bombNumber[1] + 1;
                    startPosition = i - bombNumber[1];
                }
                else
                {
                    numsToRemove = i + 1;
                    startPosition = 0;
                }


                if (i + bombNumber[1] < input.Count)
                {
                    numsToRemove += bombNumber[1];
                }
                else
                {
                    numsToRemove += input.Count - 1 - i;
                }
                while (numsToRemove > 0)
                {
                    input.RemoveAt(startPosition);
                    numsToRemove--;
                }

                



            }
            //Console.WriteLine(String.Join(" ", input));
            int sum = 0;
            foreach (var num in input)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}

