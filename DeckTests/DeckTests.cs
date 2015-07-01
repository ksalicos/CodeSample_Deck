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
            Assert.AreNotEqual(deck, null);
        }



    }
}
