using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Evolution
    {
        public string Type { get; set; }
        public int Index { get; set; }
    }
    class Pokemon
    {
        public string Name { get; set; }
        public List<Evolution> Evolutions { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            string input = Console.ReadLine();
            while (input != "wubbalubbadubdub")
            {
                if (input.Contains("->"))
                {
                    string[] data = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = data[0];
                    string type = data[1];
                    int index = int.Parse(data[2]);
                    if (pokemons.Any(x => x.Name==name))
                    {
                        Pokemon temp = pokemons.Where(x => x.Name == name).First();
                        if (temp.Evolutions == null)
                        {
                            temp.Evolutions = new List<Evolution>();
                        }
                        Evolution temporary = new Evolution();
                        temporary.Type = type;
                        temporary.Index = index;
                        temp.Evolutions.Add(temporary);
                    }
                    else
                    {
                        Pokemon temp = new Pokemon();
                        temp.Name = name;
                        temp.Evolutions = new List<Evolution>();
                        Evolution temporary = new Evolution();
                        temporary.Type = type;
                        temporary.Index = index;
                        temp.Evolutions.Add(temporary);
                        pokemons.Add(temp);
                    }
                }
                else
                {
                    string name = input;
                    if (pokemons.Any(x => x.Name == name))
                    {
                        Pokemon temp = pokemons.Where(x => x.Name == name).First();
                        Console.WriteLine("# {0}", name);
                        foreach (var evolution in temp.Evolutions)
                        {
                            Console.WriteLine("{0} <-> {1}", evolution.Type, evolution.Index);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                pokemon.Evolutions = pokemon.Evolutions.OrderByDescending(x => x.Index).ToList();
                Console.WriteLine("# {0}", pokemon.Name);
                foreach (var evolution in pokemon.Evolutions)
                {
                    Console.WriteLine("{0} <-> {1}", evolution.Type, evolution.Index);
                }
            }
        }
    }
}
