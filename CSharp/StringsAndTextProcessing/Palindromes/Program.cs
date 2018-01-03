using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ReversedString(input[i]))
                {
                    palindromes.Add(input[i]);
                }
            }
            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }
        static string ReversedString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length -1 ; i>=0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
