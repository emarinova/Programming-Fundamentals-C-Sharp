using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weather
{
    class tempAndWeather
    {
        public double temp { get; set; }
        public string weather { get; set; }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";
            Dictionary<string, tempAndWeather> weathers = new Dictionary<string, tempAndWeather>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if(Regex.Match(input,pattern).Success)
                {
                    var item = Regex.Match(input, pattern);
                    string town = item.Groups[1].Value;
                    double temp = double.Parse(item.Groups[2].Value);
                    string weather = item.Groups[3].Value;

                    if (weathers.ContainsKey(town))
                    {
                        weathers[town].temp = temp;
                        weathers[town].weather = weather;
                    }
                    else
                    {
                        weathers.Add(town, new tempAndWeather());
                        weathers[town].temp = temp;
                        weathers[town].weather = weather;
                    }
                }
                input = Console.ReadLine();
            }
            weathers = weathers.OrderBy(x => x.Value.temp).ToDictionary(x => x.Key, x => x.Value);
            foreach (var weather in weathers)
            {
                Console.WriteLine($"{weather.Key} => {weather.Value.temp} => {weather.Value.weather}");
            }
        }
    }
}
