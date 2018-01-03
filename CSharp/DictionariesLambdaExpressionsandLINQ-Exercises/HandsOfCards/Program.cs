using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':').ToArray();
            string name = input[0];
            List<string> cards = new List<string>();
            if (input.Length != 1)
            {
                cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            
            

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            Dictionary<string, int> playersResults = new Dictionary<string, int>();

            while (name != "JOKER")
            {
                if (players.ContainsKey(name))
                {
                    for (int i = 0; i < cards.Count; i++)
                    {
                        players[name].Add(cards[i]);
                    }
                }
                else
                {
                    players.Add(name, AddElementsToList(cards));
                }
                players[name] = players[name].Distinct().ToList();

                input = Console.ReadLine().Split(':').ToArray();
                name = input[0];
                if (input.Length != 1)
                {
                    cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }

            foreach (var pair in players)
            {
                int cardsPoints = 0;
                foreach (var card in pair.Value)
                {
                    cardsPoints += GetPointsForCard(card);
                }
                playersResults.Add(pair.Key, cardsPoints);
            }

            foreach (var pair in playersResults)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }

        static List<string> AddElementsToList(List<string> elements)
        {
            var list = new List<string>();
            for (int i = 0; i < elements.Count; i++)
            {
                list.Add(elements[i]);
            }
            return list;
        }

        static int GetPointsForCard(string card)
        {
            int cardPower = 0;
            int cardType = 0;

            switch (card.Substring(0, 1))
            {
                case "J":
                    cardPower = 11;
                    break;
                case "Q":
                    cardPower = 12;
                    break;
                case "K":
                    cardPower = 13;
                    break;
                case "A":
                    cardPower = 14;
                    break;
                case "1":
                    if (card.Substring(0, 2) == "10")
                        cardPower = 10;
                    else cardPower = int.Parse(card.Substring(0, 1));
                    break;
                default:
                    cardPower = int.Parse(card.Substring(0, 1));
                    break;
            }
            if (card.Substring(1, 1) == "0")
            {
                switch (card.Substring(2, 1))
                {
                    case "S":
                        cardType = 4;
                        break;
                    case "H":
                        cardType = 3;
                        break;
                    case "D":
                        cardType = 2;
                        break;
                    case "C":
                        cardType = 1;
                        break;
                    
                    default:
                    break;
                }
            }
            else
            {
                switch (card.Substring(1, 1))
                {
                    case "S":
                        cardType = 4;
                        break;
                    case "H":
                        cardType = 3;
                        break;
                    case "D":
                        cardType = 2;
                        break;
                    case "C":
                        cardType = 1;
                        break;
                    default:
                    break;
                }
            }

            return cardPower * cardType;
        }
    }
}
