using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            foreach (var banWord in bannedWords)
            {
                if (input.Contains(banWord))
                {
                    input = input.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
