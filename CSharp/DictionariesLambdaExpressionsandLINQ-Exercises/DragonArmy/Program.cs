using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            Dictionary<string, decimal[]> dragonsAv = new Dictionary<string, decimal[]>();
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToList();
                string type = input[0];
                string name = input[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                try
                {
                    damage = int.Parse(input[2]);
                }
                catch (Exception)
                {
                    damage = 45;
                }
                try
                {
                    health = int.Parse(input[3]);
                }
                catch (Exception)
                {
                    health = 250;
                }
                try
                {
                    armor = int.Parse(input[4]);
                }
                catch (Exception)
                {
                    armor = 10;
                }


                if (dragons.ContainsKey(type))

                {
                    if (dragons[type].ContainsKey(name))
                    {
                        dragons[type][name][0] = damage;
                        dragons[type][name][1] = health;
                        dragons[type][name][2] = armor;
                    }
                    else
                    {
                        dragons[type].Add(name, new List<int> { damage, health, armor });
                    }
                }
                else
                {
                    dragons.Add(type, new Dictionary<string, List<int>>());
                    dragons[type].Add(name, new List<int> { damage, health, armor });
                }
            }

            foreach (var pair in dragons)
            {
                decimal avDamage = 0;
                decimal avHealth = 0;
                decimal avArmor = 0;
                int counter = 0;
                foreach (var p in pair.Value)
                {
                    avDamage += p.Value[0];
                    avHealth += p.Value[1];
                    avArmor += p.Value[2];
                    counter++;
                }
                avDamage = avDamage / counter;
                avHealth = avHealth / counter;
                avArmor = avArmor / counter;
                dragonsAv.Add(pair.Key, new decimal[] { avDamage, avHealth, avArmor });
            }

            foreach (var pair in dragonsAv)
            {
                dragons[pair.Key] = dragons[pair.Key].OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                StringBuilder sb = new StringBuilder();
                foreach (var p in pair.Value)
                {
                    sb.Append($"{p:F2}/");

                }
                sb.Remove(sb.Length - 1, 1);
                Console.WriteLine("{0}::({1})", pair.Key, sb);
                foreach (var p in dragons[pair.Key])
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", p.Key, p.Value[0], p.Value[1], p.Value[2]);
                }
            }


        }
    }
}
