using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string[] commandLine = Console.ReadLine().Split();
            while (commandLine[0] != "END")
            {
                switch (commandLine[0])
                {
                    case "A":
                        if (!phonebook.ContainsKey(commandLine[1]))
                        {
                            phonebook.Add(commandLine[1], commandLine[2]);
                        }
                        else
                        {
                            phonebook[commandLine[1]] = commandLine[2];
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(commandLine[1]))
                        {
                            Console.WriteLine("{0} -> {1}", commandLine[1], phonebook[commandLine[1]]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", commandLine[1]);
                        }
                        break;
                    case "ListAll":
                        foreach (var pair in phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                        }
                        break;
                    default:
                        break;
                }
                commandLine = Console.ReadLine().Split();
            }
        }
    }
}

