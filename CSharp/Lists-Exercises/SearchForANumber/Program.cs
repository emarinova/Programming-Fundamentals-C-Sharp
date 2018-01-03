using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = arr[0]; i < input.Count; i++)
            {
                input.RemoveAt(i);
                i--;
            }

            int count = 0;
            while (count < arr[1])
            {
                input.RemoveAt(0);
                count++;
            }
            //Console.WriteLine(string.Join(" ", input));
            bool found = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == arr[2])
                {
                    Console.WriteLine("YES!");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
