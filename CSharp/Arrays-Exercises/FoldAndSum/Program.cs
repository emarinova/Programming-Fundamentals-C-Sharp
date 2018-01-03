using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] folded2 = new int[array.Length / 2];
            int[] folded1 = new int[array.Length / 2];
            FoldArray(array, folded1, folded2);
            int[] sum = new int[array.Length / 2];
            for (int i = 0; i<sum.Length; i++)
            {
                sum[i] = folded1[i] + folded2[i];
            }
            Console.WriteLine(String.Join(" ",sum));
        }

        static void FoldArray(int[] arr, int[] folded1, int[] folded2)
        {
            for (int i = 0; i < folded1.Length/2; i++)
            {
                folded1[i] = arr[arr.Length / 4 - 1 - i];
            }
            for (int i = 0; i < folded1.Length/2; i++)
            {
                folded1[i + folded1.Length/2] = arr[arr.Length- 1 - i];
            }
            for (int i = 0; i < folded2.Length; i++)
            {
                folded2[i] = arr[arr.Length / 4 + i];
            }
        }
    }
}
