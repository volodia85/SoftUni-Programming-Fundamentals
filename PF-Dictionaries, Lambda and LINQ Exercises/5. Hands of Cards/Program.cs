using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var cardPowers = GetPowerOfCards();
            var cardTypes = GetTypeOfCards();

            var playerCards = new Dictionary<string, HashSet<int>>();

            while (input != "JOKER")
            {
                var players = input.Split(':');
                var name = players[0];
                var cards = players[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!playerCards.ContainsKey(name))
                    {
                        playerCards[name] = new HashSet<int>();
                    }
                    playerCards[name].Add(sum);
                }
                input = Console.ReadLine();
            }
            foreach (var pair in playerCards)
            {
                var name = pair.Key;
                var cardSum = pair.Value.Sum();
            Console.WriteLine($"{name}: {cardSum}");
            }
        }

        private static Dictionary<string, int> GetTypeOfCards()
        {
            var cardType = new Dictionary<string, int>();

            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;

            return cardType;
        }

        private static Dictionary<string, int> GetPowerOfCards()
        {
            var power = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;

            }
            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;
        }
    }
}
