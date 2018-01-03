using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string words = "";

            if (word.EndsWith("y") == true)
            {
                string word2 = word.Remove(word.Length - 1);
                words = word2.Insert(word2.Length, "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                words = word.Insert(word.Length, "es");
            }
            else
            {
                words = word.Insert(word.Length, "s");
            }
            Console.WriteLine(words);
        }
    }
}
