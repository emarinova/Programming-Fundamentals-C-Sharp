using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB_MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\+359)( |-)(2)( |-)([0-9]{3})( |-)([0-9]{4})";
            string phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, regex);
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matches)
            {
                sb.Append(match.Value + ", ");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 2, 2);
            }
            Console.WriteLine(sb.ToString());
            

        }
    }
}
