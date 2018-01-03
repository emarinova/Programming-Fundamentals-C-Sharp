using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];

            //int[] numbers = { 1, 2, 3 };
            //numbers[0] = 25;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers.Length);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   numbers[i] = int.Parse(Console.ReadLine());
            //}

            int currentCount = 0;
            while(true)
            {
                string command = Console.ReadLine();
                if (command =="Print")
                {
                    Console.WriteLine(array.Length);
                }
                else
                {
                    array[currentCount] = int.Parse(command);
                    currentCount++;
                    if(currentCount>=array.Length)
                    {
                        int[] temporaty = new int[array.Length];
                        for (int i = 0; i< array.Length; i++)
                        {
                            temporaty[i] = array[i];
                        }
                        array = new int[array.Length * 2];
                        for (int i = 0; i<temporaty.Length; i++)
                        {
                            array[i] = temporaty[i];
                        }
                    }
                }
                
            }
        }
    }
}
