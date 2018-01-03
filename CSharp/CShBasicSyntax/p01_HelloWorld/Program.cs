using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //var y = 3;
            //Console.WriteLine(x+y);
            //Console.WriteLine("Hello World");
            //var z = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.WriteLine("Hi, {0}", name); //placeholder
            Console.WriteLine($"Hi, {name}");
        }
    }
}
