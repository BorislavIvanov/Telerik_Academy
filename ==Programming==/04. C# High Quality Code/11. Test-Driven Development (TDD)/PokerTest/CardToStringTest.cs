using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerTest
{
    [TestClass]
    public class CardToStringTest
    {
        [TestMethod]
        public void CardQueenSpadesTest()
        {
            Card cardInHand = new Card(CardFace.Queen, CardSuit.Spades);
            Assert.AreEqual("Q♠", cardInHand.ToString());
        }

        [TestMethod]
        public void CardTwoOfClubsTest()
        {
            Card cardInHand = new Card(CardFace.Two, CardSuit.Clubs);
            Assert.AreEqual("2♣", cardInHand.ToString());
        }
    }
}
