using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    public class PokerCard : CardBase
    {
        public enum Ranks { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
        public enum Suits { Spades, Diamonds, Clubs, Hearts }

        public readonly Ranks Rank;
        public readonly Suits Suit;

        public PokerCard(Ranks rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            string ret;
            if (Rank == Ranks.Ace) ret = "A";
            else if ((int)Rank <= 10) ret = ((int)Rank).ToString();
            else switch (Rank)
                {
                    case Ranks.Jack: 
                        ret = "J";
                        break;
                    case Ranks.Queen:
                        ret = "Q";
                        break;
                    case Ranks.King:
                        ret = "K";
                        break;
                default:
                        throw new Exception("Rank Became Invalid");//Probably not useful, but can't return ret without it.
                }
            switch (Suit)
            {
                case Suits.Clubs:
                    ret += "C";
                    break;
                case Suits.Diamonds:
                    ret += "D";
                    break;
                case Suits.Spades:
                    ret += "S";
                    break;
                case Suits.Hearts:
                    ret += "H";
                    break;
            }
            return ret;
        }

        //In poker, cards are ordered by rank, but not by suit.
        public override int CompareTo(object obj)
        {
            var other = (PokerCard)obj;
            if (Rank == other.Rank) return 0;
            return Rank > other.Rank ? 1 : -1;
        }
    }
}
