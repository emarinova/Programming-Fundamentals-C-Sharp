using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           // byte value = 0;
           // for (int i = 0; i < 260; i++)
           // {
           //     Console.WriteLine(value);
           //     value++;
           // }

            ushort value = 65535;
            value += 10;
            Console.WriteLine(value);
        }
    }
}
