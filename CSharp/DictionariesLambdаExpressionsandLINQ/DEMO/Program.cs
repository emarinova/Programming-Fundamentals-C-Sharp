using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> englishToShliokavitsa = new Dictionary<string, string>();
            englishToShliokavitsa["lamb"] = "agne";
            englishToShliokavitsa["whiskey"] = "uiski";
            englishToShliokavitsa["lamb"] = "jss";
            //englishToShliokavitsa.Remove("lamb");
            Console.WriteLine(englishToShliokavitsa["lamb"]);


            //string name = Console.ReadLine();                                       //иначе гърми, ако се подаде несъществуваш нейм
            //if (englishToShliokavitsa.ContainsKey(name))
            //{
            //    Console.WriteLine(englishToShliokavitsa[name]);
            //}
            //else
            //{
            //    Console.WriteLine("unknown");
            //}


            //foreach (KeyValuePair<string, string> item in englishToShliokavitsa)
            //{
            //    Console.WriteLine(item.Key + " - > " + item.Value);
            //}
        }
    }
}
