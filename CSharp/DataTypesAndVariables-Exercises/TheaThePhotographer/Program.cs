using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int filteredPictures = (int)Math.Ceiling(numberPictures * ((double)filterFactor / 100));
            long allFilterTime = (long)numberPictures * filterTime;
            long allUploadTime = (long)filteredPictures * uploadTime;

            long totalTime = allFilterTime + allUploadTime;


            //int seconds = (int)(totalTime % 60);
            //totalTime = totalTime / 60;
            //int minutes = (int)(totalTime % 60);
            //totalTime = totalTime / 60;
            //int hours = (int)(totalTime % 24);
            //int days = (int)(totalTime / 24);
            
            //Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");



        }
    }
}
