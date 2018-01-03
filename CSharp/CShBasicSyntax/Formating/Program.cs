using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formating
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = 5.34465;
            var percentage = 55;
            Console.WriteLine("{0:F2}", grade);
            Console.WriteLine("{0:D3}", percentage);
        }
    }
}
