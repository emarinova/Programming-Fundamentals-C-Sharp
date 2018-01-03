using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double perimeter = 2 * height + 2 * width;
            double area = height * width;
            double diagonal = Math.Sqrt(height * height + width * width);
            Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
        }
    }
}
