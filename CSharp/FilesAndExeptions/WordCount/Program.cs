using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            //int counter = 0;
            //for (int i = 0; i <words.Length; i++)
            //{
            //    for (int j = 0; j <text.Length; j++)
            //    {
            //        if (words[i] == text[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    File.AppendAllText("output.txt", words[i] + " - " + counter + Environment.NewLine);
            //    counter = 0;
            //}
            Dictionary<string, int> output = new Dictionary<string, int>();
            foreach (var word in words)
            {
                foreach(var w in text)
                {
                    if (word == w)
                    {
                        if (output.ContainsKey(word))
                        {
                            output[word]++;
                        }
                        else
                        {
                            output.Add(word, 1);
                        }
                    }
                }
            }
            output = output.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            List<string> outputt = new List<string>();
            foreach (var pair in output)
            {
                outputt.Add(pair.Key + " - " + pair.Value);
            }
            File.WriteAllLines("output.txt", outputt);
        }
    }
}
