using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();
            int numInDec = Convert.ToInt32(numInHex, 16);
            Console.WriteLine(numInDec);
        }
    }
}
