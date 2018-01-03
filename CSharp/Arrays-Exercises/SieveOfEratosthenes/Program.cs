using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n+1];
            int pow = 2;
            for (int i = 0; i <= n; i++)
                isPrime[i] = true;
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i<=n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i);
                    Console.Write(" ");
                    while(i * pow <= n)
                    {
                        isPrime[i * pow] = false;
                        pow++;
                    }
                    pow = 2;
                }
            }
            
        }
    }
}
