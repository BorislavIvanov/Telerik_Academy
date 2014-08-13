using System;
using Poker;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerTest
{
    [TestClass]
    public class HandToStringTest
    {
        [TestMethod]
        public void HandWithFourCardsTest()
        {
            Hand pokerHand = new Hand(new List<ICard>(){ 
                                new Card(CardFace.Ace, CardSuit.Hearts),
                                new Card(CardFace.King, CardSuit.Diamonds),
                                new Card(CardFace.Queen, CardSuit.Spades),
                                new Card(CardFace.Jack, CardSuit.Clubs)});

            Assert.AreEqual("A♥, K♦, Q♠, J♣", pokerHand.ToString());
        }
    }
}
