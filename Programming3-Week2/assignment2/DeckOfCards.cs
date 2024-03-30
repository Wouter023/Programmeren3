using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards;
        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();
            InitCards();
        }

        private void InitCards()
        {
            List<PlayingCard> initPlayingCards = new List<PlayingCard>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    PlayingCard playingcard = new PlayingCard(j, (CardSuit)i);
                    initPlayingCards.Add(playingcard);
                }
            }
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
