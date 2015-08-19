using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public ICard[] OrderHand()
        {
            ICard[] array = new ICard[this.Cards.Count];
            for (int count = 0; count < this.Cards.Count; count++)
            {
                array[count] = this.Cards[count];
            }

            Array.Sort(array, delegate(ICard x, ICard y) { return x.Face.CompareTo(y.Face); });
            return array;
        }

        public override string ToString()
        {
            if(this.Cards.Count == 0)
            {
                throw new ArgumentNullException("Empty hand");
            }
            string handAsString = "Hand: ";
            for (int i = 0; i < this.Cards.Count; i++)
            {
                handAsString += this.Cards[i].ToString();
                if(i != this.Cards.Count - 1)
                {
                    handAsString += ", ";
                }
            }
            return handAsString;
        }
    }
}
