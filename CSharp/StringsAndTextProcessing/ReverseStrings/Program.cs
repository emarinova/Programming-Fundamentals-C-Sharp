using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
