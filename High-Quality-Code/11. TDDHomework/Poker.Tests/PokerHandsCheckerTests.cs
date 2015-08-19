using System;
using NUnit.Framework;
using System.Collections.Generic;
using Poker;

namespace Poker.Tests
{
    [TestFixture]
    public class PokerHandsCheckerTests
    {
        // IsValidHand() Tests
        [Test]
        public void IsValidHand_With5DifferentCards_ShouldReturnTrue()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsValidHand(hand));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(7)]
        [TestCase(10)]
        public void IsValidHand_WithDifferentCards_ShouldReturnFalse(int count)
        {
            List<ICard> cards = new List<ICard>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
			{
                CardFace cardFace = (CardFace)random.Next(0, 12);
                CardSuit cardSuit = (CardSuit)random.Next(0, 3);
                cards.Add(new Card(cardFace, cardSuit));
			}

            Hand hand = new Hand(new List<ICard>());
            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_WithDuplicateCards_ShouldReturnFalse()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        // IsFlush() Tests
        [Test]
        public void IsFlush_FlushWhithValidHand_ShouldReturnTrue()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_NoFlushWhithValidHand_ShouldReturnFalse()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_WhithInValidHand_ShouldThrow()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.Throws(typeof(ArgumentException), new TestDelegate(() => {checker.IsFlush(hand);}), "IsFlush() with invalid hand should throw!");
        }

        // IsFourOfAKind() Tests
        [Test]
        public void IsFourOfAKind_FourOfAKindWhithValidHand_ShouldReturnTrue()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_FourOfAKindWhithValidHand_ShouldReturnFalse()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.AreEqual(false, checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_WhithInValidHand_ShouldThrow()
        {
            Hand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.Throws(typeof(ArgumentException), new TestDelegate(() => { checker.IsFourOfAKind(hand); }), "IsFlush() with invalid hand should throw!");
        }
    }
}
