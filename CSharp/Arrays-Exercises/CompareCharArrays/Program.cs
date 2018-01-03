using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if(arr1.Length>=arr2.Length)
            {
                CompareArray(arr1, arr2);
            }
            else
            {
                CompareArray(arr2, arr1);
            }
        }

        static void CompareArray(char[] a1, char[]a2)
        {
            bool isEqual = true;
            int first = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                if (a1[i] < a2[i])
                {
                    isEqual = false;
                    first = 1;
                }
                else if (a2[i] < a1[i])
                {
                    isEqual = false;
                    first = 2;
                }
            }
            if (first == 1)
            {
                Print(a1, a2);
            }
            else
            {
                Print(a2, a1);
            }
        }

        static void Print(char[] a1, char[] a2)
        {
            Console.WriteLine(String.Join("",a1));
            Console.WriteLine(String.Join("",a2));
        }
    }
}
