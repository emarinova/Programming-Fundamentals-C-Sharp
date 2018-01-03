using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            int leftCommonEnd = 0;
            int rightCommonEnd = 0;

            if (arr1.Length >= arr2.Length)
            {
                leftCommonEnd = CountLeftCommonEnd(arr1, arr2);
                rightCommonEnd = CountRightCommonEnd(arr1, arr2);
            }
            else
            {
                leftCommonEnd = CountLeftCommonEnd(arr2, arr1);
                rightCommonEnd = CountRightCommonEnd(arr2, arr1);
            }
            if (leftCommonEnd>=rightCommonEnd)
            {
                Console.WriteLine(leftCommonEnd);
            }
            else
            {
                Console.WriteLine(rightCommonEnd);
            }
        }

        static int CountLeftCommonEnd(string[] a1, string[] a2)
        {
            int counter = 0;
            for(int i = 0; i < a2.Length; i++)
            {
                if (a1[i] == a2[i])
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
            }
            return counter;
        }

        static int CountRightCommonEnd(string[] a1, string[] a2)
        {
            int counter = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                if (a1[a1.Length-1-i] == a2[a2.Length-1-i])
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
            }
            return counter;
        }
    }
}
