using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new char[] { ' ', ',', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();
            string usernamePattern = @"[a-zA-Z][a-zA-Z0-9_]{2,24}";
            for (int i = 0; i < usernames.Length; i++)
            {
                if (Regex.Match(usernames[i], usernamePattern).Value == usernames[i])
                {
                    validUsernames.Add(usernames[i]);
                }
            }
            int maxLenght = 0;
            int indexUsername1 = 0;

            for (int i = 0; i < validUsernames.Count-1; i++)
            {
                int tempLenght = validUsernames[i].Length + validUsernames[i+1].Length;
                if (tempLenght > maxLenght)
                {
                    maxLenght = tempLenght;
                    indexUsername1 = i;
                }
                
            }
            Console.WriteLine(validUsernames[indexUsername1]);
            Console.WriteLine(validUsernames[indexUsername1+1]);
        }
    }
}
