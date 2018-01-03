using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (i%2==1)
            //    {
            //        if (i == 1)
            //        {
            //            File.WriteAllText("output.txt", lines[i]);
            //        }
            //        else
            //        {
            //            File.AppendAllText("output.txt", Environment.NewLine + lines[i]);
            //        }
            //    }
            //}
            var outputLines = lines.Where((x, index) => index % 2 == 1);
            File.WriteAllLines("output-lines.txt", outputLines);
        }
    }
}
