using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a (.*?)>(.*?)<\/a>";
            Regex regex = new Regex(pattern);
            string replacement = "URL";
            List<string> result = new List<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                //MatchCollection matches = Regex.Matches(input, regex);
                string curResult = regex.Replace(input, m => "[URL " + m.Groups[1].Value + "]" + m.Groups[2].Value + "[/URL]");
                result.Add(curResult);
                input = Console.ReadLine();
            }
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

        }
    }
}
