using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>(52);
        public DeckOfCards()
        {
            this.allPlayingCards = InitCards();
        }

        private List<PlayingCard> InitCards()
        {
            List<PlayingCard> initPlayingCards = new List<PlayingCard>(52);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    PlayingCard playingcard = new PlayingCard(j+1, (CardSuit)i);
                    initPlayingCards.Add(playingcard);
                }
            }
            return initPlayingCards;
        }

        public void Print()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(allPlayingCards[i].ToString());
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                int number1 = random.Next(0, 52);
                int number2 = random.Next(0, 52);
                PlayingCard temperary = allPlayingCards[number1];
                allPlayingCards[number1] = allPlayingCards[number2];
                allPlayingCards[number2] = temperary;
            }
        }
    }
}
