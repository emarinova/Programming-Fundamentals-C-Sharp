using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var t = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x:D4} {y:D4} {z:D4} {t:D4}");
        }
    }
}
