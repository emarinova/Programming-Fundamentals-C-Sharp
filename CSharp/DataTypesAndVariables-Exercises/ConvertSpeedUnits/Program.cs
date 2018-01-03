using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float metersPerSeconds = distanceInMeters / (seconds + minutes * 60F + hours * 3600F);
            float kilometersPerHour = (distanceInMeters / 1000F) / (hours + minutes / 60F + seconds / 3600F);
            float milesPerHour = kilometersPerHour / 1.609F;
            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
