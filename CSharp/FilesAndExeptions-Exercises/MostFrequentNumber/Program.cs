using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            int mostFrequent = arr[0];
            int howMany = 1;
            int count = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count > howMany)
                {
                    howMany = count;
                    mostFrequent = arr[i];

                }
                count = 1;
            }

            File.WriteAllText("output.txt", mostFrequent.ToString());
        }
    }
}
