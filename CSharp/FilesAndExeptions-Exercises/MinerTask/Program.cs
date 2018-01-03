using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string[] resourcesAndQuantity = File.ReadAllLines("input.txt");
            string resource = resourcesAndQuantity[0];
            int index = 0;
            while (resource != "stop")
            {
                int quantity = int.Parse(resourcesAndQuantity[index+1]);
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
                resource = resourcesAndQuantity[index+2];
                index += 2;
            }
            string[] output = new string[resources.Count];
            int indexer = 0;
            foreach (var pair in resources)
            {
                
                output[indexer] = $"{pair.Key} -> {pair.Value}";
                indexer++;
                //Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
