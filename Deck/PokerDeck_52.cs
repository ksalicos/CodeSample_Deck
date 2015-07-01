using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    public class PokerDeck_52 : DeckBase
    {
        public PokerDeck_52(bool fill = true)
        {
            if (!fill) return;
            var suits = Enum.GetValues(typeof(PokerCard.Suits)).Cast<PokerCard.Suits>();
            var ranks = Enum.GetValues(typeof(PokerCard.Ranks)).Cast<PokerCard.Ranks>();
            foreach (var r in ranks)
            {
                foreach (var s in suits)
                {                    
                    Cards.Add(new PokerCard(r, s));
                }
            }
        }

        new public PokerCard GetNext()
        {
            return (PokerCard)base.GetNext();
        }
    }
}
