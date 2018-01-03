using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var random = new Random(); //нов обект от класа Random
            // int a = random.Next();
            // Console.WriteLine(a); //произволно число
            for (int i = 0; i < words.Length; i++)
            {
                int swapIndexFirst = random.Next(0, words.Length);
            
                
                int swapIndexSecond = random.Next(0, words.Length);
               
                string swap = words[swapIndexFirst];
                words[swapIndexFirst] = words[swapIndexSecond];
                words[swapIndexSecond] = swap;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
