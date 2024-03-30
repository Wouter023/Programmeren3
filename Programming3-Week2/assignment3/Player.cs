using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Player
    {
        public string name;
        public List<PlayingCard> playingcards;

        public Player(string name)
        {
            this.name = name;
            this.playingcards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            playingcards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard card = playingcards[0];
            playingcards.RemoveAt(0);
            return card;
        }


    }
}
