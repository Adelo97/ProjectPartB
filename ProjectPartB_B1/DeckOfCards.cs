using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class DeckOfCards : IDeckOfCards
    {
        #region cards List related
        protected const int MaxNrOfCards = 52;
        protected List<PlayingCard> cards = new List<PlayingCard>(MaxNrOfCards);
        private Random random  = new Random();

        public PlayingCard this[int idx] => cards[idx];
        public int Count => cards.Count;
        #endregion

        #region ToString() related
        public override string ToString()
        {
            return string.Join(", ", cards.Select(card => card.ToString()));
        }
        #endregion

        #region Shuffle and Sorting
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                int k = random.Next(n--);
                var temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }
        public void Sort()
        {
            cards.Sort();
         }
        #endregion

        #region Creating a fresh Deck
        public void Clear()
        {
            cards.Clear();
         }
        public void CreateFreshDeck()
        {
            Clear();
            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                for (int rank = 2; rank <= 14; rank++) // Assuming 2-10, J=11, Q=12, K=13, A=14
                {
                    cards.Add(new PlayingCard((Suit)suit, rank));
                }
            }
         }
        #endregion

        #region Dealing
        public PlayingCard RemoveTopCard()
        {
            if (cards.Count == 0) return null;
            var topCard = cards.Last();
            cards.RemoveAt(cards.Count - 1);
            return topCard;
        }
        #endregion
    }
}
