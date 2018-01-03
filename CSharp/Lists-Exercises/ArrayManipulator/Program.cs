using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            string[] commandLine = Console.ReadLine().Split(' ');
            
            while (commandLine[0] != "print")
            {
               
                switch (commandLine[0])
                {
                    case "add":
                        int inde = int.Parse(commandLine[1]);
                        int e = int.Parse(commandLine[2]);
                        numbers.Insert(inde, e);
                        break;
                    case "addMany":
                        int index = int.Parse(commandLine[1]);
                        for(int i = 2; i < commandLine.Length; i++, index++)
                        {
                            numbers.Insert(index, int.Parse(commandLine[i]));
                        }
                        break;
                    case "contains":
                        int element = int.Parse(commandLine[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    case "remove":
                        int ind = int.Parse(commandLine[1]);
                        numbers.RemoveAt(ind);
                        break;
                    case "shift":
                        int positions = int.Parse(commandLine[1]);
                        while (positions != 0)
                        {
                            shiftPosition(numbers);
                            positions--;
                        }
                        break;
                    case "sumPairs":
                        if(numbers.Count % 2 ==0)
                        {
                            for(int i = 0; i<numbers.Count; i++)
                            {
                                numbers[i] = numbers[i] + numbers[i + 1];
                                numbers.RemoveAt(i + 1);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count - 1; i++)
                            {
                                numbers[i] = numbers[i] + numbers[i + 1];
                                numbers.RemoveAt(i + 1);
                            }
                        }
                        break;
                    default:
                        break;

                }
                commandLine = Console.ReadLine().Split(' ');
            }
            Console.Write("[");
            Console.Write(String.Join(", ",numbers));
            Console.Write("]");
        }

        

        static void shiftPosition(List<int> list)
        {
            int element = list[0];
            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[list.Count - 1] = element;
        }

        
    }
}
