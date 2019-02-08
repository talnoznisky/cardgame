using System;
namespace cardgame
{
    public class Player
    {
        public Player(int score, int hand, string name, bool winner)
        {
            Score = score;
            Hand = hand;
            Name = name;
            Winner = winner;

        }
        public int Score { get; set; }
        public int Hand { get; set; }
        public string Name { get; set; }
        public bool Winner { get; set; }

    }
}
