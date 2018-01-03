using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string patternSent = @"[A-Z].*?(?:[.!?])";
            string pattern = $@"\b{word}\b";
            
            MatchCollection sentances = Regex.Matches(input, patternSent);
            foreach (Match sentance in sentances)
            {
                if (Regex.Match(sentance.Value, pattern).Success)
                 {
                    var sentanceWithout = sentance.Value.Remove(sentance.Length - 1);
                    Console.WriteLine(sentanceWithout);
                }
            }
        }
    }
}
