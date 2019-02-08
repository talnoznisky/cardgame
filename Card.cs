using System;
using System.Collections.Generic;
using System.Text;

namespace cardgame
{
    public class Card
    {
        public Card(string suit, string value, int score)
        {
            Suit = suit;
            Value = value;
            Score = score;
        }

        public string Suit { get; }
        public string Value { get; }
        public int Score { get; }


        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
