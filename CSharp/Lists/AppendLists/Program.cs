using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] lists = Console.ReadLine().Split('|').ToArray();
            for (int i = lists.Length -1; i >= 0; i--)
            {
                
                List<int> result = new List<int>(lists[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
                Console.Write(String.Join(" ",result) + " ");
            }

        }
    }
}
