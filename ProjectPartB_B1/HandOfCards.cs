using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        #region Pick and Add related
        public void Add(PlayingCard card)
        {
            if  (cards.Count<MaxNrOfCards)
            {
                cards.Add(card);
            }

         }
        #endregion

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                if (cards == null || cards.Count == 0)
                return null;

            PlayingCard highestCard = cards[0];

            foreach (var card in cards)
            {
                if (card.CompareTo(highestCard) > 0)
                {
                    highestCard = card;
                }
            }
            return highestCard;
            }
         }
        public PlayingCard Lowest
        {
            get
            {
                if (cards == null || cards.Count == 0)
                return null;

            PlayingCard lowestCard = cards[0];

            foreach (var card in cards)
            {
                if (card.CompareTo(lowestCard) < 0)
                {
                    lowestCard = card;
                }
            }
            return lowestCard;
            }
        }
        #endregion
    }
}
