using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = pokemons.Count;
            int sumOfRemoved = 0;
            int removed = 0;
            while (count > 0)
            {
                int i = int.Parse(Console.ReadLine());
                if (i >= 0 && i < pokemons.Count)
                {
                    removed = pokemons[i];
                    sumOfRemoved += removed;
                    pokemons.RemoveAt(i);

                    count--;
                }
                else if (i < 0)
                {
                    removed = pokemons[0];
                    sumOfRemoved += removed;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (i >= pokemons.Count )
                {
                    removed = pokemons[pokemons.Count - 1];
                    sumOfRemoved += removed;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                for (int j = 0; j < pokemons.Count; j++)
                {
                    if (pokemons[j] <= removed)
                    {
                        pokemons[j] += removed;
                    }
                    else
                    {
                        pokemons[j] -= removed;
                    }
                }
            }
            Console.WriteLine(sumOfRemoved);
        }
    }
}
