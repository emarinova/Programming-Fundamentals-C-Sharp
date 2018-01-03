using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculateFolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles("TestFolder");
            long sizeBytes = 0;
            foreach (var path in filePaths)
            {
                FileInfo info = new FileInfo(path);
                sizeBytes += info.Length;
            }
            double sizeMegabytes = (double)(sizeBytes / 1024) / 1024;
            File.WriteAllText("output.txt", sizeMegabytes.ToString());
        }
    }
}
