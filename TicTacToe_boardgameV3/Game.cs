using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TicTacToe_boardgame;

namespace TicTacToe_boardgameV3
{
    public class Game
    {
        private int GameStatus;

        public Game()
        { 
            bool intro = true;
            
            while (intro)
            {
                
                Board bd = new Board();
                Player p1 = new Player();
                Player p2 = new Player();

                GameStatus = 0;
                
                int currentTurn = StartGame( p1, p2);

                Console.Clear();
                
                while (GameStatus != 1 && GameStatus != -1)
                {
                    int currentPlayerId = currentTurn % 2 != 0 ? 1 : 0;
                    Player cpi = currentPlayerId == 1 ? p1 : p2;
                    
                    Console.Clear();
                    Console.WriteLine("{0}:{1} and {2}:{3}", p1.Name, p1.Token, p2.Name, p2.Token);
                    Console.WriteLine("Its {0}'s turn, pick a spot to place your token: {1}", cpi.Name, cpi.Token);

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
                    int[] validInput = {1, 2, 3, 4, 5, 6, 7, 8, 9};
                    bool validPick = true;

                    if (int.TryParse(Console.ReadLine(), out playerPick))
                    {
                        if (!validInput.Contains(playerPick))
                        {
                            validPick = false;    
                        }
                    }
                    else
                    {
                        validPick = false;
                    }
               

                    if (validPick)
                    {
                        if ( TakeTurn(cpi.Token, playerPick, bd)) 
                        {
                            currentTurn++;
                            Console.Clear();
                            Console.WriteLine("Validating results");
                            displayProgressbar(10);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input, please try again ");
                        displayProgressbar(20);
                    }
                    ValidateResults(bd);
                    
                    bd.DisplayBoard();
                    
                    if (GameStatus == 1)
                    {
                        Console.WriteLine("{0} WON!", cpi.Name);
                    }

                    if (GameStatus == -1)
                    {
                        Console.WriteLine("ITS A DRAW!");
                    }
                }

                Console.WriteLine("To play again enter P, to quit enter Q");

                string input = Console.ReadLine();
                if (input != null) intro = input.ToUpper() == "P";
            }
        }

        private int StartGame( Player p1, Player p2)
        {
            var rnd = new Random();

            Console.Clear();

            Console.WriteLine("Welcome to tic tac toe");
            
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter player {0} name:", i);
                var p = i == 1 ? p1 : p2;
                
                p.Name = Console.ReadLine();
                
            }

            p1.Token = Token.TokenType.X;
            
            p2.Token = Token.TokenType.O;

            Console.Clear();

            Console.WriteLine("Welcome {0} and {1}! \n", p1.Name, p2.Name);
            
            Console.WriteLine("{0} will play with: {1} and {2} will play with: {3} \n", p1.Name, p1.Token, p2.Name, p2.Token);
           
            Console.WriteLine("Lets get started, press a key when you are ready to move on");

            Console.ReadKey();
            Console.Clear();
            
            Console.Write("Randomizing who will start... \n");

            int playerToStart = rnd.Next(0, 2+1);
            var pts = playerToStart == 1 ? p1 : p2;
                    
            displayProgressbar(20);

            Console.Clear();
            
            Console.WriteLine("{0} was chosen to start! Click when you're ready to play!", pts.Name);
            Console.ReadKey();
                
            return playerToStart; 
        }

        private bool TakeTurn( Token.TokenType tokenType, int fieldPicked, Board bd)
        {
            if (bd.Fields[fieldPicked].FieldState != "X" && bd.Fields[fieldPicked].FieldState != "O")
            {
                bd.Fields[fieldPicked].FieldState = tokenType.ToString();
                return true;
            }

            Console.Clear();
            Console.WriteLine("Sorry row {0} is already marked with {1}", fieldPicked, bd.Fields[fieldPicked].FieldState);
            displayProgressbar(20);
            return false;
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

        private void displayProgressbar(int ms)
        {
            var pgb = new ProgressBar();
            using (pgb) {
                for (int i = 0; i <= 100; i++) {
                    pgb.Report((double) i / 100);
                    Thread.Sleep(ms);
                }
            }   
        }

    }
}