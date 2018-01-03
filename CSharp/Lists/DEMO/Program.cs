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
            //List<string> names = new List<string>();
            //names.Add("Sofia");
            //Console.WriteLine(names[0]);


            string inputLine = Console.ReadLine();

            string[] items = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //string [] items = inputLine.Split(' ');

            List<int> numbers = new List<int>();
            foreach (var item in items)
            {
                numbers.Add(int.Parse(item));
            }
        }
    }
}
