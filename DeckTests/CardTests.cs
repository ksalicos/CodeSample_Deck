using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deck;

namespace DeckTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void PokerCardConstructorRuns()
        {
            var card = new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Spades);
            Assert.AreNotEqual(card, null);
        }

        [TestMethod]
        public void PokerCardCompareGreater()
        {
            var bigcard = new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Spades);
            var smallcard = new PokerCard(PokerCard.Ranks.Two, PokerCard.Suits.Diamonds);
            Assert.IsTrue(bigcard.CompareTo(smallcard) > 0);
        }

        [TestMethod]
        public void PokerCardCompareLess()
        {
            var bigcard = new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Spades);
            var smallcard = new PokerCard(PokerCard.Ranks.Two, PokerCard.Suits.Diamonds);
            Assert.IsTrue(smallcard.CompareTo(bigcard) < 0);
        }

        [TestMethod]
        public void PokerCardCompareEqual()
        {
            var card = new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Spades);
            var othercard = new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Diamonds);
            Assert.IsTrue(card.CompareTo(othercard) == 0);
        }

    }
}
