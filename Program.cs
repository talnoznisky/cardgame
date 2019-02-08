using System;
using System.Linq;

namespace cardgame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();


            deck.Shuffle();
            /*
            Console.WriteLine(deck);

            Console.WriteLine("<><><><><><><><><><> ");

            Deck otherDeck = new Deck();
            otherDeck.Shuffle();

            Console.WriteLine(otherDeck);
            Console.ReadLine();
            */
            Player Computer = new Player(0);
            Player Human = new Player(0);

            for (int i = 0; i < (deck.Cards.Length/2); i++)
            {
                Console.WriteLine($"\nRound {i+1}:");

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