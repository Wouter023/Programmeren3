using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            string stringRank;
            switch (rank)
            {
                
                case 11:
                    stringRank = "Jack";
                    break;
                case 12:
                    stringRank = "Queen";
                    break;
                case 13:
                    stringRank = "King";
                    break;
                case 14:
                    stringRank = "Ace";
                    break;
                default:
                    stringRank = $"{rank}";
                    break;
            }

            return $"{stringRank} of {suit}";
        }


    }
}
