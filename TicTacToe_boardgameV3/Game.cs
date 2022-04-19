using System;
using System.Collections.Generic;
using System.Threading;
using TicTacToe_boardgame;

namespace TicTacToe_boardgameV3
{
    public class Game
    {
        private Board Board;

        private int GameStatus;

        public Game()
        {
            var bd = new Board();

            var p1 = new Player();
            var p2 = new Player(); 
            int playerCount = 2;
            int currentTurn = 0;
            bool intro = true;
            while (intro)
            {
                Console.Clear();
                
                if (intro)
                {
                    currentTurn = StartGame(playerCount, p1, p2);
                }

                while (GameStatus != 1 && GameStatus != -1)
                {
                    Console.WriteLine("{0}:{1} and {2}:{3}", p1.Name, p1.PlayerTokens, p2.Name, p2.PlayerTokens);
                
                    int currentPlayerId;
                    currentPlayerId = currentTurn % 2 != 0 ? 1 : 0;
                    var cpi = currentPlayerId == 1 ? p1 : p2;
                    
                    Console.WriteLine("{0}'s turn", cpi.Name);

                    if (intro)
                    {
                        bd.CreateBoard();
                        intro = false;    
                    }
                    else
                    {
                        bd.DisplayBoard();
                    }

                    int playerPick;
                    while (!int.TryParse(Console.ReadLine(), out playerPick))
                    {
                        Console.WriteLine("Not valid ");
                    }
                
                    TakeTurn(cpi.PlayerTokens[0], playerPick, bd);
                    currentTurn++;
                
                    ValidateResults(bd);
                
                    if (GameStatus == 1)
                    {
                        Console.WriteLine("SOMEONE WON! {0}", currentTurn);
                        Console.ReadKey();
                    }

                    if (GameStatus == -1)
                    {
                        Console.WriteLine("DRAW {0}", currentTurn);
                        Console.ReadKey();
                    }
                }
            }
        }

        private int StartGame( int playerCount, Player p1, Player p2)
        {
            var rnd = new Random();
            Token.TokenType tokenType;

            Console.Clear();

            Console.WriteLine("Welcome to tic tac toe");
            
            for (int i = 1; i <= playerCount; i++)
            {
                Console.WriteLine("Enter player {0} name:", i);
                var p = i == 1 ? p1 : p2;

                p.Name = Console.ReadLine();
                
            }
            
            Console.Clear();

            Console.WriteLine("Welcome {0} and {1}! \n", p1.Name, p2.Name);
            
            Console.WriteLine("{0} will play with: {1} and {2} will play with: {3} \n", p1.Name, p1.GetTokenType(), p2.Name, p2.GetTokenType());
           
            Console.WriteLine("Lets get started, press a key when you are ready to move on");

            Console.ReadKey();
            Console.Clear();
            
            Console.Write("Randomizing who will start... \n");

            int playerToStart = rnd.Next(0, playerCount+1);
            var pts = playerToStart == 1 ? p1 : p2;
                    
            var pgb = new ProgressBar();
            using (pgb) {
                for (int i = 0; i <= 100; i++) {
                    pgb.Report((double) i / 100);
                    Thread.Sleep(20);
                }
            }

            Console.Clear();
            
            Console.WriteLine("{0} was chosen to start! Click when you're ready to play!", pts.Name);
                
            return playerToStart; 
        }

        private void TakeTurn( Token token, int FieldPicked, Board bd)
        {
            if (bd.Fields[FieldPicked].FieldState != "X" && bd.Fields[FieldPicked].FieldState != "O")
            {
                bd.Fields[FieldPicked].FieldState = token.ToString();
            }
            else
            {
                Console.WriteLine("Sorry the row {0} is already marked with {1}\n", FieldPicked, bd.Fields[FieldPicked]);
                Console.WriteLine("Please wait 2 seconds while the board is loading again.....");
                Thread.Sleep(2000);

            }
        }

        private void ValidateResults(Board bd)
        {
            // First Row   1/2/3
            if (bd.Fields[1].FieldState == bd.Fields[2].FieldState &&
                bd.Fields[2].FieldState == bd.Fields[3].FieldState)
            {
                GameStatus = 1;
            }

            // Second Row 4/5/6
            else if (bd.Fields[4].FieldState == bd.Fields[5].FieldState &&
                     bd.Fields[5].FieldState == bd.Fields[6].FieldState)
            {
                GameStatus = 1;
            }

            // Third Row 6/7/8
            else if (bd.Fields[6].FieldState == bd.Fields[7].FieldState &&
                     bd.Fields[7].FieldState == bd.Fields[8].FieldState)
            {
                GameStatus = 1;
            }

            // First Column 1/4/7
            else if (bd.Fields[1].FieldState == bd.Fields[4].FieldState &&
                     bd.Fields[4].FieldState == bd.Fields[7].FieldState)
            {
                GameStatus = 1;
            }

            // Second Column 2/5/8
            else if (bd.Fields[2].FieldState == bd.Fields[5].FieldState &&
                     bd.Fields[5].FieldState == bd.Fields[8].FieldState)
            {
                GameStatus = 1;
            }

            // Third Column 3/6/9

            else if (bd.Fields[3].FieldState == bd.Fields[6].FieldState &&
                     bd.Fields[6].FieldState == bd.Fields[9].FieldState)
            {
                GameStatus = 1;
            }

            // Diagonally 1/5/9
            else if (bd.Fields[1].FieldState == bd.Fields[5].FieldState &&
                     bd.Fields[5].FieldState == bd.Fields[9].FieldState)
            {
                GameStatus = 1;
            }

            // Diagonally 3/5/7
            else if (bd.Fields[3].FieldState == bd.Fields[5].FieldState &&
                     bd.Fields[5].FieldState == bd.Fields[7].FieldState)
            {
                GameStatus = 1;
            }

            // Draw

            else if (bd.Fields[1].FieldState != "1" && bd.Fields[2].FieldState != "2" &&
                     bd.Fields[3].FieldState != "3" && bd.Fields[4].FieldState != "4" &&
                     bd.Fields[5].FieldState != "5" && bd.Fields[6].FieldState != "6" &&
                     bd.Fields[7].FieldState != "7" && bd.Fields[8].FieldState != "8" && 
                     bd.Fields[9].FieldState != "9")
            {
                GameStatus = -1;
            }

            else
            {
                // game still going
                GameStatus = 0;
            }
        }
    }
}