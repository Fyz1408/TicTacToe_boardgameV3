using System;
using System.Collections.Generic;
using System.Threading;
using TicTacToe_boardgame;

namespace TicTacToe_boardgameV3
{
    public class Game
    {
        public List<Player> Players;
        
        public Board Board;

        private int GameStatus;

        public Game()
        {
            var bd = new Board();
            var rnd = new Random();
            
            int playerCount = 2;
            bool showIntro = true;

            while (GameStatus != 1 && GameStatus != -1)
            {
                if (showIntro)
                {
                    Players = new List<Player>();
                    for (int i = 1; i <= playerCount; i++)
                    {
                        Players.Add(
                            new Player(i)
                        );
                    }
            
                    Console.Clear();

                    Console.WriteLine("Welcome to tic tac toe");
                
                    foreach (var p in Players)
                    {
                        Console.WriteLine("Enter player {0} name:", p.PlayerID);
                        p.PlayerName = Console.ReadLine();
                    }
            
                    Console.Clear();

                    Console.WriteLine("Welcome {0} and {1}! \n", Players[0].PlayerName, Players[1].PlayerName);
            
                    Console.WriteLine("{0} will play with noughts: O and {1} will play with crosses: X \n", Players[0].PlayerName, Players[1].PlayerName);
            
                    Console.WriteLine("Lets get started, press a key when you are ready to move on\n");

                    Console.ReadKey();
                    Console.Clear();
            
                    Console.Write("Randomizing who will start... \n");
            
                    int playerIdToStart = rnd.Next(0, 3);

                    var pgb = new ProgressBar();
                    using (pgb) {
                        for (int i = 0; i <= 100; i++) {
                            pgb.Report((double) i / 100);
                            Thread.Sleep(20);
                        }
                    }

                    Console.Clear();
            
                    foreach (var p in Players)
                    {
                        if (p.PlayerID == playerIdToStart)
                        {
                            Console.WriteLine("{0} was chosen to start! Click when you're ready to play!", p.PlayerName);
                        }
                    }

                    Console.ReadKey();
                }
                
                Console.Clear();
                
                Console.WriteLine("Its your turn {0}");
                
                bd.CreateBoard();    
                
                Console.ReadKey();
                
            }
        }

        public void StartGame(Player[] Players, Board board)
        {
            
            
            
        }

        public void takeTurn( Player PlayersTurn, int FieldID)
        {
            
        }

        private void ValidateResults(Board board)
        {

        }

        public bool checkDraw(int takeTurn)
        {
            if (takeTurn == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}