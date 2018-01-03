using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> venuesAndsingers = new Dictionary<string, Dictionary<string, int>>();
            List<string> venues = new List<string>();
            string[] input = Console.ReadLine().Split('@').ToArray();
            while (input[0] != "End")
            {
                if (!input[0].EndsWith(" "))
                {
                    input = Console.ReadLine().Split('@').ToArray();
                    continue;
                }
                string singer = input[0].Substring(0, input[0].Length - 1);
                string[] venueAndtickets = input[1].Split().ToArray();
                int tickets = 0;
                int price = 0;
                try
                {
                    tickets = int.Parse(venueAndtickets[venueAndtickets.Length - 1]);
                    price = int.Parse(venueAndtickets[venueAndtickets.Length - 2]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine().Split('@').ToArray();
                    continue;
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < venueAndtickets.Length - 2; i++)
                {
                    sb.Append(venueAndtickets[i] + " ");
                }
                sb.Remove(sb.Length - 1, 1);
                string venue = sb.ToString();

                if (venuesAndsingers.ContainsKey(venue))
                {
                    if (venuesAndsingers[venue].ContainsKey(singer))
                    {
                        venuesAndsingers[venue][singer] = venuesAndsingers[venue][singer] + (tickets * price);
                    }
                    else
                    {
                        venuesAndsingers[venue].Add(singer, tickets * price);
                    }
                }
                else
                {
                    venuesAndsingers.Add(venue, new Dictionary<string, int>());
                    venuesAndsingers[venue].Add(singer, tickets * price);
                }
                if(!venues.Contains(venue))
                {
                    venues.Add(venue);
                }
                input = Console.ReadLine().Split('@').ToArray();
            }

            foreach (var venue in venues)
            {
                venuesAndsingers[venue] = venuesAndsingers[venue].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }

            foreach (var venueAndsingers in venuesAndsingers)
            {
                Console.WriteLine(venueAndsingers.Key);
                foreach (var singerAndtickets in venueAndsingers.Value)
                {
                    Console.WriteLine("#  {0} -> {1}", singerAndtickets.Key, singerAndtickets.Value);
                }
            }
        }
    }
}
