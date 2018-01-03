using System;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double  quantity = double.Parse(Console.ReadLine());
            double price = 0.00;
            switch (profession)
            {
                case "Athlete":
                    price = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1.0;
                    break;
                case "SoftUni Student":
                    price = quantity * 1.7;
                    break;
                default:
                    price = quantity * 1.2;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
