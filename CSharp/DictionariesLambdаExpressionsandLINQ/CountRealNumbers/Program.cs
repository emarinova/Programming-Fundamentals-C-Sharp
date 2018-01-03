using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            for(int i = 0; i < nums.Count; i++)
            {
                if(!count.ContainsKey(nums[i]))
                {
                    count[nums[i]] = 1;
                }
                else
                {
                    count[nums[i]]++;
                }
            }
            foreach (KeyValuePair<double, int> ocurance in count)
            {
                Console.WriteLine(ocurance.Key + " -> " + ocurance.Value);
            }
        }
    }
}
