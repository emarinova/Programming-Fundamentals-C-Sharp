using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"([\w\+%20]*.*?=[\w\+%20]*.*?)(&|$)";
            string patternToRemove = @"\+|%20";
            
            while (inputLine != "END")
            {
                List<string> result = new List<string>();
                Dictionary<string, List<string>> resultFinal = new Dictionary<string, List<string>>();
                MatchCollection pairs = Regex.Matches(inputLine, pattern);
                foreach (Match match in pairs)
                {
                    if (match.Groups[1].Value.Contains("?"))
                    {
                        var temp = match.Groups[1].Value.Split('?');
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i].Contains("="))
                            {
                                var pair = Regex.Replace(temp[i], patternToRemove, " ");
                                pair = Regex.Replace(pair, @" {2,}", " ");
                                result.Add(pair);
                            }
                        }
                    }
                    else
                    {
                        var pair = Regex.Replace(match.Groups[1].Value, patternToRemove, " ");
                        pair = Regex.Replace(pair, @" {2,}", " ");
                        result.Add(pair);
                    }

                }
                foreach (var pair in result)
                {
                    var stringResult = pair.Split('=').ToArray();
                    var key = stringResult[0].Trim();
                    var value = stringResult[1].Trim();
                    if (resultFinal.ContainsKey(key))
                    {
                        resultFinal[key].Add(value);
                    }
                    else
                    {
                        resultFinal.Add(key, new List<string>());
                        resultFinal[key].Add(value);
                    }
                }
                foreach (var pair in resultFinal)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }
                Console.WriteLine();
                inputLine = Console.ReadLine();
            }
            
        }
    }
}
