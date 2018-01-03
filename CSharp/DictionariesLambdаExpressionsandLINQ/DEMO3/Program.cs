using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "coffee", "vodka", "main" };
            Dictionary<string, int> wordLengths = new Dictionary<string, int();
            foreach ( var word in words)
            {
                wordLengths[word] = word.Length;
            }

            Dictionary<string,int> wordLengths2 = words.ToDictionary(word => word, word => word.Length);
        }
    }
}
