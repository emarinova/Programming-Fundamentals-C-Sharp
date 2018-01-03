using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines1 = File.ReadAllLines("input1.txt");
            string[] lines2 = File.ReadAllLines("input2.txt");

            File.WriteAllLines("output.txt", lines1);
            File.AppendAllLines("output.txt", lines2);
        }
    }
}
