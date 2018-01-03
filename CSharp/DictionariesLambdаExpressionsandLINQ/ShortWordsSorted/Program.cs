using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries));
            var uniqueWords = words.Distinct().ToList();
            var shortWords = uniqueWords.Where(x => x.Length < 5).OrderBy(x => x);
            Console.WriteLine(string.Join(", ",shortWords));
        }
    }
}
