using System;

namespace CubeProperties
{
    class Program
    {
        static double GetFaceDiagonal(double s)
        {
            return Math.Sqrt(2 * s * s);
        }

        static double GetSpaceDiagonal(double s)
        {
            return Math.Sqrt(3 * s * s);
        }

        static double GetVolume(double s)
        {
            return Math.Pow(s, 3);
        }

        static double GetArea(double s)
        {
            return 6 * s * s;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face":
                    Console.WriteLine($"{GetFaceDiagonal(side):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{GetSpaceDiagonal(side):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{GetVolume(side):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{GetArea(side):F2}");
                    break;

                default:
                    break;
            }
        }
    }
}
