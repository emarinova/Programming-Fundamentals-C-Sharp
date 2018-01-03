using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numInHex = Convert.ToString(num, 16).ToUpper();
            string numInBinary = Convert.ToString(num, 2);
            
            Console.WriteLine($"{numInHex}\r\n{numInBinary}");


        }
    }
}
