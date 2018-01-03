using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int counter = 0;
            int powerRemaining = N;
            while(powerRemaining >= M)
            {
                powerRemaining -= M;
                counter++;
                if (powerRemaining * 2 == N && powerRemaining >= Y && Y != 0)
                {
                    
                        powerRemaining /= Y;
                    
                }
            }
            Console.WriteLine(powerRemaining);
            Console.WriteLine(counter);
        }
    }
}
