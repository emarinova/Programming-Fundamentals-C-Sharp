using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyLine = Console.ReadLine();
            string keyPattern = @"^(.*?)[<\|\\].*[<\|\\](.*?)$";
            string stringLine = Console.ReadLine();

            var key = Regex.Match(keyLine, keyPattern);
            string stringPattern = $@"{key.Groups[1].Value}(.*?){key.Groups[2].Value}";

            MatchCollection betweens = Regex.Matches(stringLine, stringPattern);

            StringBuilder sb = new StringBuilder();
            foreach (Match between in betweens)
            {
                sb.Append(between.Groups[1].Value);
            }
            if (sb.ToString().Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(sb.ToString());
            }

        }
    }
}
