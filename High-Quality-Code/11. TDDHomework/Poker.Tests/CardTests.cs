using System;
using NUnit.Framework;
using Poker;

namespace Poker.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void CardToString_WithValidFaceAndSuit_ShoulPrintCorrectResult()
        {
            foreach(CardFace face in Enum.GetValues(typeof(CardFace)))
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Card card = new Card(face, suit);
                    string expected = "Card: " + face + " " +suit;
                    Assert.AreEqual(expected, card.ToString(), "Card.ToString() with valid input should print correct result!");
                }
            }
        }
    }
}
