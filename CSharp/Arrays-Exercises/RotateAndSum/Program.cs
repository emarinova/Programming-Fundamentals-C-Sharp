using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i< sum.Length; i++)
            {
                sum[i] = 0;
            }

            for (int i = 1; i<= rotateTimes; i++)
            {
                array = GetRotatedArray(array);
                for (int j = 0; j< sum.Length; j++)
                {
                    sum[j] += array[j];
                }
            }
            Console.WriteLine(String.Join(" ",sum));


        }

        static int[] GetRotatedArray(int[] arr)
        {

            int[] rotated = new int[arr.Length];
            rotated[0] = arr[arr.Length - 1];
            for(int i=1; i < arr.Length; i++)
            {
                rotated[i] = arr[i - 1];
            }
            return rotated;
        }
    }
}
