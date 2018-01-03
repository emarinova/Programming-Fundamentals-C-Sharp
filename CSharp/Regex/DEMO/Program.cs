using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[0-9]";
            string input = Console.ReadLine();
            string replacement = "a";

            Regex regex = new Regex(pattern); // movje da se izpolzva mnogo puti
            bool contains = regex.IsMatch(input);
            MatchCollection all = regex.Matches(input);

            string result = regex.Replace(input, replacement);
            Console.WriteLine(result);

            MatchCollection matches = Regex.Matches(input, pattern);

            string result2 = Regex.Replace(input, pattern, (s) =>
                {
                    switch (s.Value)
                    {
                        case "0": return "{zero}"; break;
                        case "1": return "{one}"; break;
                        case "2": return "{two}"; break;
                        default: return "{}";  break;
                    }
                });
            Console.WriteLine(result2);

            Regex.Match(input, pattern); // purviq match

            Regex.IsMatch(input, pattern); // ima li

            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                Console.WriteLine(m.Groups[1]); // m.Groups["numbers"];
            }
        }
    }
}
