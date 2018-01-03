using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            int n = int.Parse(File.ReadAllText("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions - Exercises\\AdvertisementMessage\\input.txt"));
            string[] output = new string[n];
            for (int i = 0; i < n; i++)
            {
                int phrasesIndex = random.Next(0, phrases.Length - 1);
                int eventsIndex = random.Next(0, events.Length - 1);
                int authorsIndex = random.Next(0, authors.Length - 1);
                int citiesIndex = random.Next(0, cities.Length - 1);
                output[i] = $"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}";
                //Console.WriteLine("{0} {1} {2} - {3}", phrases[phrasesIndex], events[eventsIndex], authors[authorsIndex], cities[citiesIndex]);
            }
            File.WriteAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\AdvertisementMessage\\in\\output.txt", output);
        }
    }
}
