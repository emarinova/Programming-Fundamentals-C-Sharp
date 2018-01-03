using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(File.ReadAllText("input.txt").Split().Select(int.Parse).ToList());
            int bestStart = 0;
            int bestLength = 1;
            int length = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    length++;
                    if (i == numbers.Count - 2 && length > bestLength)
                    {

                        bestLength = length;
                        bestStart = i + 2 - length;
                    }
                }
                else
                {
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = i + 1 - length;
                        length = 1;
                    }
                    else
                    {
                        length = 1;
                    }
                }
            }
            string output = "";
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                output = output + numbers[i].ToString() + " ";
            }
            File.WriteAllText("output.txt", output);
        }
    }
}
