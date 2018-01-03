using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
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

                    default:
                        break;
                }
                commandLine = Console.ReadLine().Split();
            }
        }
    }
}
