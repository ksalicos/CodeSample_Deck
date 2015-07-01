using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deck;

namespace DeckTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void PokerDeckConstructorRuns()
        {
            var deck = new PokerDeck_52();
            Assert.AreEqual(deck.Count, 52);
        }

        [TestMethod]
        public void PokerDeckEmptyConstructorRuns()
        {
            var deck = new PokerDeck_52(false);
            Assert.AreEqual(deck.Count, 0);
        }

        [TestMethod]
        public void SortCheckWorks()
        {
            var deck = new PokerDeck_52(false);
            deck.PutOnBottom(new PokerCard(PokerCard.Ranks.Two, PokerCard.Suits.Spades));
            deck.PutOnBottom(new PokerCard(PokerCard.Ranks.Five, PokerCard.Suits.Spades));
            deck.PutOnBottom(new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Hearts));
            deck.PutOnBottom(new PokerCard(PokerCard.Ranks.Ace, PokerCard.Suits.Spades));
            Assert.IsTrue(deck.IsSorted());
            deck.PutOnBottom(new PokerCard(PokerCard.Ranks.Three, PokerCard.Suits.Spades));
            Assert.IsFalse(deck.IsSorted());
        }


        [TestMethod]
        public void PokerDeckShuffled()
        {
            //I'll leave deep analysis to the math majors.  If the list isn't still in order, it's shuffled
            //Visual inspection should give a good idea of how effective we were
            //I mainly just want to make sure it doesn't crash.
            var deck = new PokerDeck_52();
            deck.Shuffle();
            Assert.IsFalse(deck.IsSorted());
        }



        [TestMethod]
        public void PokerDeckSorted()
        {
            //Note: This test is useless if shuffle fails
            var deck = new PokerDeck_52();
            deck.Shuffle();
            deck.Sort();
            Assert.IsTrue(deck.IsSorted());
        }



    }
}
