using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte[] bytes = File.ReadAllBytes("text.");
            string contents = File.ReadAllText("example.txt");                                                     //от папката на ексето
            string contentsFromOtherDir = File.ReadAllText("D:\\Programing\\Tech Module\\CSharp\\example.txt");    //от друга директория
            string contentsFromSub = File.ReadAllText("sub\\example.txt");                                         //от подпапка
            Console.WriteLine(contents);
            Console.WriteLine(contentsFromOtherDir);
            Console.WriteLine(contentsFromSub);
            string[] lines = File.ReadAllLines("example.txt");
            // string[] lines = contents.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            Console.WriteLine(lines[0]);

            for (int i = 0; i<lines.Length; i++)
            {
                lines[i] = i + " " + lines[i];
            }

            Console.WriteLine(lines[0]);
        }
    }
}
