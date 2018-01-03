using System;
using System.Linq;
using System.Collections.Generic;

public class BePositive
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool found = false;

            for (int j = 0; j < input.Length; j++)
            {
                int currentNum = input[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else if (j!=input.Length-1)
                {
                    currentNum += input[j + 1];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                        j++;
                }
                if (j == input.Length-1 && found)
                {
                    Console.WriteLine("");
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}