using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (arr1.Length>arr2.Length)
            {
                int[] sum = new int[arr1.Length];
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum[i] = arr1[i] + arr2[i % arr2.Length];
                }
                Console.WriteLine(String.Join(" ", sum));
            }
            else
            {
                int[] sum = new int[arr2.Length];
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum[i] = arr2[i] + arr1[i % arr1.Length];
                }
                Console.WriteLine(String.Join(" ", sum));
            }
            
        }
    }
}
