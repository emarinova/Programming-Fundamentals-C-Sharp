using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "Joro", Age = 25, ID = 123 }; // dynamic тип
            var student0 = new { Name = Console.ReadLine() };
            var date = new DateTime(2016, 5, 3); //съществуващ клас
            Console.WriteLine(date);
            Console.WriteLine(student.Name);
        }
    }
}
