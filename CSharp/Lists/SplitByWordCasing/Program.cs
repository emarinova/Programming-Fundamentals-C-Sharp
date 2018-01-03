using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>(Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            int lowercase = 0;
            int uppercase = 0;
            int other = 0;

            foreach(var item in input)
            {
                for(int i = 0; i < item.Length; i++)
                {
                    if (char.IsLower(item[i]))
                    {
                        lowercase++;
                    }
                    else if (char.IsUpper(item[i]))
                    {
                        uppercase++;
                    }
                    else other++;
                }
                if (uppercase == 0 && other == 0)
                {
                    lowerCaseWords.Add(item);
                }
                else if(lowercase == 0 && other == 0)
                {
                    upperCaseWords.Add(item);
                }
                else
                {
                    mixedCaseWords.Add(item);
                }
                lowercase = 0;
                uppercase = 0;
                other = 0;
            }
            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCaseWords));

        }
    }
}
