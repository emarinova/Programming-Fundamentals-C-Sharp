using System;
namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshosDamage = int.Parse(Console.ReadLine());
            int GoshosDamage = int.Parse(Console.ReadLine());

            int round = 0;
            int PeshosHealth = 100;
            int GoshosHealth = 100;

            while (PeshosHealth>0 && GoshosHealth>0)
            {
                round++;
                GoshosHealth -= PeshosDamage;
                if (GoshosHealth <=0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshosHealth} health.");
                }
                if (round%3==0)
                {
                    GoshosHealth += 10;
                    PeshosHealth += 10;
                }
                round++;
                PeshosHealth -= GoshosDamage;
                if (PeshosHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshosHealth} health.");
                }
                if (round % 3 == 0)
                {
                    GoshosHealth += 10;
                    PeshosHealth += 10;
                }
            }
        }
    }
}
