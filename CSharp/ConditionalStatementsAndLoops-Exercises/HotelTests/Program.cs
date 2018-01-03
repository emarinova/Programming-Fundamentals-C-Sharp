using System;

namespace HotelTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;


            switch (month)
            {
                case "october":
                case "may":
                    studioPrice = nightsCount * 50;
                    doublePrice = nightsCount * 65;
                    suitePrice = nightsCount * 75;
                    if (nightsCount > 7)
                    {
                        studioPrice = 0.95 * studioPrice;
                    }
                    break;
                case "june":
                case "september":
                    studioPrice = nightsCount * 60;
                    doublePrice = nightsCount * 72;
                    suitePrice = nightsCount * 82;
                    if (nightsCount > 14)
                    {
                        doublePrice = 0.9 * doublePrice;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioPrice = nightsCount * 68;
                    doublePrice = nightsCount * 77;
                    suitePrice = nightsCount * 89;
                    if (nightsCount > 14)
                    {
                        suitePrice = 0.85 * suitePrice;
                    }
                    break;

                default:
                    break;
            }
            if (month == "september" && nightsCount > 7)
            {
                nightsCount--;
                studioPrice = nightsCount * 60;
            }
            if (month == "october" && nightsCount > 7)
            {
                nightsCount--;
                studioPrice = 0.95 * nightsCount * 50;
            }
            Console.WriteLine($"Studio: {studioPrice:F2} lv.\r\nDouble: {doublePrice:F2} lv.\r\nSuite: {suitePrice:F2} lv.");
        }
    }
}
