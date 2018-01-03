using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            List<string> commandLine = new List<string>();
            int item, position;
            do
            {
                commandLine = Console.ReadLine().Split(' ').ToList();
                switch (commandLine[0])
                {
                    case "Delete":
                        item = int.Parse(commandLine[1]);
                        DeleteItemInList(input, item);
                        break;
                    case "Insert":
                        item = int.Parse(commandLine[1]);
                        position = int.Parse(commandLine[2]);
                        InsertItemInList(input, item, position);
                        break;
                    case "Odd":
                        ReturnOnlyOddElements(input);
                        break;
                    case "Even":
                        ReturnOnlyEvenElements(input);
                        break;
                    default:
                        break;
                }
            }
            while (commandLine[0] != "Odd" && commandLine[0] != "Even");
            Console.WriteLine(String.Join(" ",input));
        }

        static void DeleteItemInList(List<int> list, int item)
        {
            while(list.IndexOf(item)>=0)
            {
                list.Remove(item);
            }
        }

        static void InsertItemInList(List<int> list, int item, int index)
        {
            list.Insert(index, item);
        }

        static void ReturnOnlyEvenElements(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        static void ReturnOnlyOddElements(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
