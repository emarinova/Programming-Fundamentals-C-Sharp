using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int k = input.Count / 4;
            var row1left = input.Take(k).Reverse().ToList();
            var row1right = input.Skip(3 * k).Take(k).Reverse().ToList();
            var row1 = row1left.Concat(row1right).ToList();
            var row2 = input.Skip(k).Take(2 * k).ToList();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
