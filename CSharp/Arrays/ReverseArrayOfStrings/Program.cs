using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] reverse = new string[arr.Length];
            for (int i = 0; i < arr.Length ; i++)
            
            {
                reverse[i] = arr[arr.Length - 1 - i];
            }
            Console.WriteLine(String.Join(" ", reverse));
        }

        
    }

}
