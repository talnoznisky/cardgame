
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace cardgame
{
    public class Deck
    {
        //This is a special type of method called a constructor.
        //it is run every time you create a deck of cards
        public Deck()
        {
            string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] scores = new int[52];

            for(int i = 1; i < 14; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    scores[i] = i;
                }
            }

            Cards = new Card[52];
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Cards[(i * values.Length) + j] = new Card(suits[i], values[j], scores[j]);

                }
            }
        }

        public Card[] Cards { get; private set; }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = 0; i < this.Cards.Length * 100; i++)
            {

                int position1 = rng.Next(0, this.Cards.Length);
                int position2 = rng.Next(0, this.Cards.Length);
                Card temp = this.Cards[position1];
                this.Cards[position1] = this.Cards[position2];
                this.Cards[position2] = temp;
            }
        }

        public override string ToString()
        {
            return string.Join(",", Cards.Select(x => x.ToString()));
        }

        int deckPosition = 0;
        public Card Draw()
        {
            Card DrawnCard = Cards[deckPosition];
            deckPosition++;
            return DrawnCard;

        }


        public void PlayGame(Card HumansCard, Card ComputersCard, Player player1, Player player2)
        {
            if (HumansCard.Score == ComputersCard.Score)
                {
                player2.Score++;
                player1.Score++;
                Console.WriteLine("It's a tie :) + :(");

                }
                else if (HumansCard.Score > ComputersCard.Score)
                {
                player1.Score++;
                Console.WriteLine("Player win :)");
                }
                else
                {
                player2.Score++;
                Console.WriteLine("Computer win :(");
                }


        }

        public void DeclareWinner(Player player1, Player player2)
        {

            Console.WriteLine($"\nYour score: {player1.Score}");
            Console.WriteLine($"Computer's score: {player2.Score}");
            if(player1.Score > player2.Score)
            {
                Console.WriteLine("Congratulations! You won!");
            }
            else
            {
                Console.WriteLine("Oh shit you fucked up.");
            }
        }
    }


}
