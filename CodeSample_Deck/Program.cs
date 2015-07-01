using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deck;

namespace CodeSample_Deck
{
    class Program
    {
        public enum Suits { Spades, Diamonds, Clubs, Hearts }

        static void Main(string[] args)
        {
            Console.WriteLine("Code Sample: Kevin Salicos");
            var deck = new PokerDeck_52();
            Console.WriteLine("Base:");
            Console.WriteLine(deck);
            deck.Shuffle();
            Console.WriteLine("Shuffled:");
            Console.WriteLine(deck);
            deck.Sort();
            Console.WriteLine("Sorted:");
            Console.WriteLine(deck);
            var results = new int[52];
            var count = 100000f;
            for (var i = 0; i < count; i++)
            {
                deck = new PokerDeck_52();
                deck.Shuffle();
                for (var j = 0; j < 52; j++)
                {
                    results[j] += (int)deck.GetNext().Rank;
                }
            }
            Console.WriteLine("Average Value At Position: ");
            Console.WriteLine(string.Format("0: {0}", results[0] / count));
            Console.WriteLine(string.Format("20: {0}", results[20] / count));
            Console.WriteLine(string.Format("51: {0}", results[51] / count));
            Console.ReadLine();
        }
    }
}
