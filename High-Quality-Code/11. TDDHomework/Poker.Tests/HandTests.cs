using System;
using NUnit.Framework;
using Poker;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestFixture]
    public class HandTests
    {
        [Test]
        public void HandToString_With5Cards_ShouldPrintsCorrectResult()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            string expected = "Hand: ";
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                expected += hand.Cards[i].ToString();
                if (i != hand.Cards.Count - 1)
                {
                    expected += ", ";

                }
            }

            Assert.AreEqual(expected, hand.ToString(), "Hand.ToString() with valid cards should print correct result!");
        }

        [Test]
        public void HandToString_WithNoCards_ShouldThrow()
        {
            Hand hand = new Hand(new List<ICard>());

            Assert.Throws(typeof(ArgumentNullException), new TestDelegate(() => { hand.ToString(); }), "Hand.ToString() with no cards should throw!");
        }
    }
}
