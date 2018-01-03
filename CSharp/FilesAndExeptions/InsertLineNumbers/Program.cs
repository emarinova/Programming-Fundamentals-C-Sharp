using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InsertLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    File.AppendAllText("output.txt", i + 1 + ". " + lines[i] + Environment.NewLine);
            //}
            var numbered = lines.Select((x, index) => $"{index + 1}. {x}");
            File.WriteAllLines("output.txt", numbered);
        }
    }
}
