using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[] {
                new DateTime(2010, 01, 01), new DateTime(2010, 03, 03), new DateTime(2010, 05, 01), new DateTime(2010, 05, 06), new DateTime(2010, 05, 24), new DateTime(2010, 09, 06),
                new DateTime(2010, 09, 22), new DateTime(2010, 11, 01), new DateTime(2010, 12, 24), new DateTime(2010, 12, 25), new DateTime(2010, 12, 26) };

            int counter = 0;
            bool holiday = false;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (i.Day == holidays[j].Day && i.Month == holidays[j].Month)
                        {
                            holiday = true;
                        }
                    }
                    if (!holiday)
                    {
                        counter++;
                        
                    }
                }
                holiday = false;
            }
            Console.WriteLine(counter);
        }
    }
}
