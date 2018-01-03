using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    
                    break;
                }
           
            }
            Console.WriteLine(count);

        }
    }
}
