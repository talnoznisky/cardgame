using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace cardgame
{

    public class Game
    {
        public Player[] Players { get; set; }

        public void RunGame(string[] names)
        {
            Players = new Player[2];
            for(int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player(0, names[i]);
            }

            Deck deck = new Deck();
            deck.Shuffle();


            for (int i = 0; i < (deck.Cards.Length / 2); i++)
            {
                Console.WriteLine($"\nRound {i + 1}:");

                Card HumansCard = deck.Draw();
                Console.Write($"Your card: {HumansCard}");

                Card ComputersCard = deck.Draw();
                Console.Write($"\nComputer's card: {ComputersCard}\n");

                deck.PlayGame(HumansCard, ComputersCard, Human, Computer);

            }
            deck.DeclareWinner(Human, Computer);


        }
    }
}
