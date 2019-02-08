using System;
namespace cardgame
{
    public class Player
    {
        public Player(int score, string name)
        {
            Score = score;
            Name = name;
        }
        public int Score { get; set; }
        public string Name { get; set; }
    }
}
