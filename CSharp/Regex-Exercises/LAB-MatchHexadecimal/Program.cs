using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_MatchHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
