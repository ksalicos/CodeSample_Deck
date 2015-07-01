using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deck;

namespace DeckTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void PokerCardConstructorRuns()
        {
            var card = new PokerCard();
            Assert.AreNotEqual(card, null);
        }

        [TestMethod]
        public void PokerDeckConstructorRuns()
        {
            var deck = new PokerDeck_52();
            Assert.AreNotEqual(deck, null);
        }


    }
}
