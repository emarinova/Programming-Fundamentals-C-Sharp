using System;
namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static string GetLastDigitName(long n)
        {
            int lastDigit = (int)(n % 10);
            string nameOfLastDigit = "";
            switch (lastDigit)
            {
                case 1:
                    nameOfLastDigit = "one";
                    break;
                case 2:
                    nameOfLastDigit = "two";
                    break;
                case 3:
                    nameOfLastDigit = "three";
                    break;
                case 4:
                    nameOfLastDigit = "four";
                    break;
                case 5:
                    nameOfLastDigit = "five";
                    break;
                case 6:
                    nameOfLastDigit = "six";
                    break;
                case 7:
                    nameOfLastDigit = "seven";
                    break;
                case 8:
                    nameOfLastDigit = "eight";
                    break;
                case 9:
                    nameOfLastDigit = "nine";
                    break;
                case 0:
                    nameOfLastDigit = "zero";
                    break;
                default:
                    break;
            }
            return nameOfLastDigit;
        }
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            string lastDigitName = GetLastDigitName(number);
            Console.WriteLine(lastDigitName);
        }
    }
}
