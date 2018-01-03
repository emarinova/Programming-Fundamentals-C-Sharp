using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            var largestThreeNums = nums.OrderByDescending(num => num).Take(3);
            Console.WriteLine(String.Join(" ",largestThreeNums));
        }
    }
}
