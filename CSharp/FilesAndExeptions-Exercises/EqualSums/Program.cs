using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = File.ReadAllText("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\EqualSums\\input.txt").Split().Select(int.Parse).ToArray();
            int index = -1;
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int k = i + 1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                File.WriteAllText("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\EqualSums\\output.txt", "no");
            }
            else
                File.WriteAllText("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\EqualSums\\output.txt", index.ToString());
        }
    }
}
