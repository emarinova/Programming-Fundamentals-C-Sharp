using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int counter = 1;
            int countedAtPosition = 0;
            int count = 1;
            int positionCount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if (j == arr.Length -1)
                        {
                            if (count > counter)
                            {
                                counter = count;
                                countedAtPosition = positionCount;
                            }
                            
                            i = j - 1;
                            break;
                        }
                    }
                    else
                    {
                        if (count > counter)
                        {
                            counter = count;
                            count = 1;
                            countedAtPosition = positionCount;
                            positionCount = j;
                            i = j - 1;
                            break;
                        }
                        else
                        {
                            positionCount = j;
                            count = 1;
                            i = j - 1;
                            break;
                        }
                    }
                }
            }
            for (int i = countedAtPosition; i < countedAtPosition + counter; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
    }
}


