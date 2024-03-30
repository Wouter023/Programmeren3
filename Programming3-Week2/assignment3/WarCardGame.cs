using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class WarCardGame : CardGame
    {
        public Player player1, player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();

            for (int i = 0; i < deck.allPlayingCards.Count; i++)
            {
                if (i % 2 == 0)
                {
                    player1.AddCard(deck.allPlayingCards[i]);
                }
                else
                {
                    player2.AddCard(deck.allPlayingCards[i]);
                }
            }
        }

        public bool EndOfGame()
        {
            if (player1.playingcards.Count == 0 || player2.playingcards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NextCard()
        {
            PlayingCard card1 = player1.GetNextCard();
            PlayingCard card2 = player2.GetNextCard();

            Console.WriteLine($"[{player1.name}] {card1} - [{player2.name}] {card2}");

            if(card1.rank > card2.rank)
            {
                Console.WriteLine($"{player1.name} got the cards");
                player1.AddCard(card1);
                player1.AddCard(card2);
            }
            else if (card1.rank < card2.rank)
            {
                Console.WriteLine($"{player2.name} got the cards");
                player2.AddCard(card2);
                player2.AddCard(card1);
            }
            else
            {
                Console.WriteLine($"2 cards lost..." +
                    $"\ncards left: [{player1.name}] {player1.playingcards.Count}x, [{player2.name}] {player2.playingcards.Count}x");
            }
        }
    }
}
