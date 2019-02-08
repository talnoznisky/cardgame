using System;
namespace cardgame
{
    public class Player
    {
        public Player(int score)
        {
            Score = score;
        }
        public int Score { get; set; }
    }
}
