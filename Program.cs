using System;
using System.Linq;

namespace cardgame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Here's a comment.
            //Here's another comment.
            //Here's a third comment.
            Deck deck = new Deck();

            deck.Shuffle();
            Console.WriteLine(deck);

            Console.WriteLine("<><><><><><><><><><> ");

            Console.Write("Your card: ");
            deck.Draw();

            Console.Write("\nComputer's card: ");
            deck.Draw();
            /*
            Deck otherDeck = new Deck();
            otherDeck.Shuffle();

            Console.WriteLine(otherDeck);
            Console.ReadLine();
            */

        }
    }
}