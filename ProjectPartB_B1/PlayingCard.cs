using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
	public class PlayingCard:IComparable<PlayingCard>
	{	
		public enum Suit{get}
		public enum Rank{get}
		public Suit Suit { get; set; }
		public Rank Rank { get; set; }
		public PlayingCard(Suit suit,int  rank)
		{
			Suit = suit;
			Rank = (Rank)rank;
		}

		public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }

        public int CompareTo(PlayingCard other)
        {
            if (other == null) return 1;
            return Rank.CompareTo(other.Rank);
        }

		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }
		
		#region 
		//Need only to compare value in the project
		public int CompareTo(PlayingCard card1)
        {
			if (card1 == null) return 1;
			return this.Value.CompareTo(card1.Value);
        }
		#endregion

        #region ToString() related
		string ShortDescription
		{
		
			get
			{
				return $"{Value}of{Color}";
			}
		}

		public override string ToString() => ShortDescription;
		}

    	public enum PlayingCardColor{Hearts, Diamonds, Clubs, Spades}
    	public enum PlayingCardValue{Ace, Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King}
		
#endregion
}
