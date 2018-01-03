using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collectedMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            collectedMaterials.Add("shards", 0);
            collectedMaterials.Add("motes", 0);
            collectedMaterials.Add("fragments", 0);

            string legendaryItem = "";
            List<string> input = new List<string>();
            do
            {
                input = Console.ReadLine().ToLower().Split().ToList();
                for (int i = 0; i < input.Count - 1; i = i + 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (collectedMaterials.ContainsKey(material))
                    {


                        collectedMaterials[material] += quantity;
                        if (legendaryItem == "" && collectedMaterials[material] >= 250)
                        {
                            legendaryItem = GetLegendaryItem(collectedMaterials[material], material);
                            collectedMaterials[material] -= 250;
                            break;
                        }
                    }

                    else if (junk.ContainsKey(material))
                    {
                        junk[material] += quantity;
                    }
                    else
                    {
                        junk.Add(material, quantity);
                    }
                }


            }
            while (legendaryItem == "");


            Console.WriteLine("{0} obtained!", legendaryItem);

            collectedMaterials = collectedMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in collectedMaterials)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            junk = junk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in junk)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

        }

        static string GetLegendaryItem(int quantity, string material)
        {
            string legendaryItem = "";

            switch (material)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;
                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
                case "fragments":
                    legendaryItem = "Valanyr";
                    break;
                default:
                    break;
            }

            return legendaryItem;
        }


    }
}
