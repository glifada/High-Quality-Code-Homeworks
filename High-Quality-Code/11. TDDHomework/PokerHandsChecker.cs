using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private int[] FindFaceFrequency(IHand hand)
        {
            int[] frequency = new int[14];
            for (int count = 0; count < hand.Cards.Count; count++)
            {
                int face = (int)hand.Cards[count].Face;
                frequency[face - 2]++;
            }

            return frequency;
        }

        private int FindMaxFaceFrequency(IHand hand)
        {
            int[] faceFrequency = FindFaceFrequency(hand);
            int maxFaceFrequency = 0;
            for (int count = 0; count < faceFrequency.Length; count++)
            {
                if (faceFrequency[count] > maxFaceFrequency)
                {
                    maxFaceFrequency = faceFrequency[count];
                }
            }

            return maxFaceFrequency;
        }

        public bool IsRow(IHand hand)
        {
            bool isRow = true;
            ICard[] orderedHand = ((Hand)hand).OrderHand();
            for (int count = 1; count < orderedHand.Length; count++)
            {
                if ((int)orderedHand[count - 1].Face + 1 != (int)orderedHand[count].Face)
                {
                    isRow = false;
                    break;
                }
            }

            return isRow;
        }

        public bool IsSameSuit(IHand hand)
        {
            bool isSameSuit = true;
            CardSuit firstCardSuit = hand.Cards[0].Suit;
            for (int count = 1; count < hand.Cards.Count; count++)
            {
                CardSuit nextCardSuit = hand.Cards[count].Suit;
                if (firstCardSuit != nextCardSuit)
                {
                    isSameSuit = false;
                    break;
                }
            }

            return isSameSuit;
        }
        public bool IsValidHand(IHand hand)
        {
            bool isValid = true;

            if (hand.Cards.Count != 5)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < hand.Cards.Count - 1; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            hand.Cards[i].Suit == hand.Cards[j].Suit)
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
            }

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            int maxFaceFrequency = FindMaxFaceFrequency(hand);
            bool isSameSuit = IsSameSuit(hand);
            bool isRow = IsRow(hand);

            bool isStraightFlush = isValidHand && (maxFaceFrequency == 1) && isRow && isSameSuit;
            return isStraightFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                throw new ArgumentException("Invalid hand!");
            }

            bool isFour = false;

            for (int i = 0; i < 2; i++)
            {
                int faceCounter = 1;
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        faceCounter += 1;
                    }
                }

                if (faceCounter == 4)
                {
                    isFour = true;
                    break;
                }
            }
            return isFour;
        }

        public bool IsFullHouse(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            int[] faceFrequency = FindFaceFrequency(hand);
            bool isThree = false;
            bool isTwo = false;
            for (int count = 0; count < faceFrequency.Length; count++)
            {
                if (faceFrequency[count] == 2)
                {
                    isTwo = true;
                }

                if (faceFrequency[count] == 3)
                {
                    isThree = true;
                }
            }

            bool isFullHouse = isValidHand && isThree && isTwo;
            return isFullHouse;
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                throw new ArgumentException("Invalid hand!");
            }

            bool isFlush = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    isFlush = false;
                    break;
                }
            }
            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            int maxFaceFrequency = FindMaxFaceFrequency(hand);
            bool isSameSuit = IsSameSuit(hand);
            bool isRow = IsRow(hand);

            bool isStraight = isValidHand && isRow && (maxFaceFrequency == 1) && !isSameSuit;
            return isStraight;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            bool isFullHouse = IsFullHouse(hand);
            int maxFaceFrequency = FindMaxFaceFrequency(hand);

            bool isThreeOfAKind = isValidHand && !isFullHouse && (maxFaceFrequency == 3);
            return isThreeOfAKind;
        }

        public bool IsTwoPair(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            int[] faceFrequency = FindFaceFrequency(hand);
            byte pair = 0;
            for (int count = 0; count < faceFrequency.Length; count++)
            {
                if (faceFrequency[count] == 2)
                {
                    pair++;
                }
            }

            bool isTwoPair = isValidHand && (pair == 2);
            return isTwoPair;
        }

        public bool IsOnePair(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            bool isTwoPair = IsTwoPair(hand);
            int maxFaceFrequency = FindMaxFaceFrequency(hand);

            bool isOnePair = isValidHand && !isTwoPair && (maxFaceFrequency == 2);
            return isOnePair;
        }

        public bool IsHighCard(IHand hand)
        {
            bool isValidHand = IsValidHand(hand);
            int maxFaceFrequency = FindMaxFaceFrequency(hand);
            bool isSameSuit = IsSameSuit(hand);
            bool isRow = IsRow(hand);

            bool isHighCard = isValidHand && !isRow && !isSameSuit && (maxFaceFrequency == 1);
            return isHighCard;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (!IsValidHand(firstHand) || !IsValidHand(secondHand))
            {
                throw new ArgumentException(
                    "One of the hands is invalid! You cannot compare invalid hands.");
            }

            Combination firstHandCombination = FindCombination(firstHand);
            Combination secondHandCombination = FindCombination(secondHand);
            int result = firstHandCombination.CompareTo(secondHandCombination);
            return result;
        }

        public Combination FindCombination(IHand hand)
        {
            Combination combination = Combination.HighCard;
            if (IsOnePair(hand))
            {
                combination = Combination.OnePair;
            }
            else if (IsTwoPair(hand))
            {
                combination = Combination.TwoPair;
            }
            else if (IsThreeOfAKind(hand))
            {
                combination = Combination.ThreeOfAKind;
            }
            else if (IsStraight(hand))
            {
                combination = Combination.Straight;
            }
            else if (IsFlush(hand))
            {
                combination = Combination.Flush;
            }
            else if (IsFullHouse(hand))
            {
                combination = Combination.FullHouse;
            }
            else if (IsFourOfAKind(hand))
            {
                combination = Combination.FourOfAKind;
            }
            else if (IsStraightFlush(hand))
            {
                combination = Combination.StraightFlush;
            }

            return combination;
        }
    }
}
