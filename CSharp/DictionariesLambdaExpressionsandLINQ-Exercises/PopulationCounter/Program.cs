using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            Dictionary<string, Dictionary<string, int>> population = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, long> populationCountry = new Dictionary<string, long>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                int people = int.Parse(input[2]);

                if (population.ContainsKey(country))
                {
                    if(population[country].ContainsKey(city))
                    {
                        population[country][city] += people;
                    }
                    else
                    {
                        population[country].Add(city, people);
                    }
                }
                else
                {
                    population.Add(country, new Dictionary<string, int>());
                    population[country].Add(city, people);
                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var countryAndCity in population)
            {
                long populationForCountry = 0;
                foreach (var cityAndPeople in countryAndCity.Value)
                {
                    populationForCountry += (long)cityAndPeople.Value;
                }
                populationCountry.Add(countryAndCity.Key, populationForCountry);
            }

            populationCountry = populationCountry.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var pair in populationCountry)
            {
                string p = pair.Key;
                population[p] = population[p].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }
            foreach (var pair in populationCountry)
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value);
                foreach (var p in population[pair.Key])
                {
                    Console.WriteLine("=>{0}: {1}", p.Key, p.Value);
                }
            }
        }
    }
}
