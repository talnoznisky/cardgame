using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace cardgame
{

    public class Game
    {
        public Player[] Players { get; set; }
        public Player[] Winners { get; set; }

        public void RunGame(string[] names)
        {
            Players = new Player[2];
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player(0, 0, names[i], false);
            }

            Deck deck = new Deck();
            deck.Shuffle();

            void DeclareWinner(Player[] players)
            {
                int HighestValue = Players.Max(x => x.Hand);
                for (int i = 0; i < Players.Length; i++)
                {
                    if (Players[i].Hand == HighestValue)
                    {
                        Players[i].Winner = true;
                    }
                }
                Console.WriteLine($"This round's winner(s):");
                for (int j = 0; j < Players.Length; j++)
                {
                    if (Players[j].Winner == true)
                    {
                        Players[j].Score = +1;
                        Console.WriteLine(Players[j].Name);
                    }
                }
                for (int k = 0; k < Players.Length; k++)
                {
                    Players[k].Winner = false;
                }

            }

            void Round()
            {
                for (int i = 0; i < (deck.Cards.Length / 2); i++)
                {
                    Console.WriteLine($"\nRound {i + 1}:");

                    for (int j = 0; j < Players.Length; j++)
                    {
                        Card card = deck.Draw();
                        Players[j].Hand = card.Score;
                        Console.WriteLine($"{Players[j].Name}'s card: {card}");
                    }
                    DeclareWinner(Players);
                }

            }

            Round();
        }




        }
    }

