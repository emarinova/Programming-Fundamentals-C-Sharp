using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(Console.ReadLine().ToLower().Split().ToList());
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            List<string> result = new List<string>();
            foreach (var word in words)
            {
                if (!occurrences.ContainsKey(word))
                {
                    occurrences[word] = 1;
                }
                else
                {
                    occurrences[word]++;
                }
            }
            foreach (KeyValuePair<string, int> occurre in occurrences)
            {
                if (occurre.Value % 2 == 1)
                {
                    result.Add(occurre.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
