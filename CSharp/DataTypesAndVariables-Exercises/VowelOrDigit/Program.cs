using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isVowel = "aeouiy".IndexOf(input) >= 0;
            bool isDigit = "0123456789".IndexOf(input) >= 0;
            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }

    }
}
