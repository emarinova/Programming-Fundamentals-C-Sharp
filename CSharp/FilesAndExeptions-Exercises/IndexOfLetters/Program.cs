using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\IndexOfLetters\\input.txt");
            string[] lines = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                
                lines[i] = $"{input[i]} -> {(int)input[i] - 97}";
            }
            File.WriteAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\IndexOfLetters\\output.txt", lines);
        }
    }
}
