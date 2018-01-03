using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            //Console.WriteLine("ID: {0:D8}", id);
            //Console.WriteLine("Salary: {0:D2}", salary);
            Console.WriteLine($"ID: {id:D8}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
