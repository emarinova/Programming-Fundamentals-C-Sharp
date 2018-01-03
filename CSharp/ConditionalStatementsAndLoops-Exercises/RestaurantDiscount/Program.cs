using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            string hall = "";
            double hallPrice = 0;
            double totalPrice = 0;
            double pricePerPerson = 0;

            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {


                switch (package)
                {
                    case "normal":
                        if (people <= 50)
                        {
                            hall = "Small Hall";
                            hallPrice = 2500;
                        }
                        else if (people > 50 && people <= 100)
                        {
                            hall = "Terrace";
                            hallPrice = 5000;
                        }
                        else if (people > 100 && people <= 120)
                        {
                            hall = "Great Hall";
                            hallPrice = 7500;
                        }
                        totalPrice = 0.95 * (hallPrice + 500);
                        pricePerPerson = totalPrice / people;
                        break;
                    case "gold":
                        if (people <= 50)
                        {
                            hall = "Small Hall";
                            hallPrice = 2500;
                        }
                        else if (people > 50 && people <= 100)
                        {
                            hall = "Terrace";
                            hallPrice = 5000;
                        }
                        else if (people > 100 && people <= 120)
                        {
                            hall = "Great Hall";
                            hallPrice = 7500;
                        }
                        totalPrice = 0.9 * (hallPrice + 750);
                        pricePerPerson = totalPrice / people;
                        break;
                    case "platinum":
                        if (people <= 50)
                        {
                            hall = "Small Hall";
                            hallPrice = 2500;
                        }
                        else if (people > 50 && people <= 100)
                        {
                            hall = "Terrace";
                            hallPrice = 5000;
                        }
                        else if (people > 100 && people <= 120)
                        {
                            hall = "Great Hall";
                            hallPrice = 7500;
                        }
                        totalPrice = 0.85 * (hallPrice + 1000);
                        pricePerPerson = totalPrice / people;
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
