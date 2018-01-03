using System;


namespace IWillBeBackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours -= 24;   //if da sa napisani po ednakuw nachin; moje lesno da se promeni, ako uslovieto se promeni za razlichni minuti
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
