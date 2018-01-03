using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_CharacterStats
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var ch = int.Parse(Console.ReadLine());
            var mh = int.Parse(Console.ReadLine());
            var ce = int.Parse(Console.ReadLine());
            var me = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: " + new string('|', ch+1) + new string('.', mh - ch) + "|");
            Console.WriteLine("Energy: " + new string('|', ce + 1) + new string('.', me - ce) + "|");

        }
    }
}
