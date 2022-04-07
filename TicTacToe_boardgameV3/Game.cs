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
            var p1 = new Player(1);
            var p2 = new Player(2);
            
            int playerCount = 2;
            int currentTurn = 0;
            bool intro = true;
            int playerPick;

            while (GameStatus != 1 && GameStatus != -1)
            {
                Console.Clear();
                
                if (intro)
                {
                    currentTurn = StartGame(playerCount);
                }

                Console.WriteLine("{0}:{1} and {2}:{3}", Players[0].PlayerName,  Players[0].PlayerType, Players[1].PlayerName,  Players[1].PlayerType);
                
                if (currentTurn % 2 == 0) 
                {
                    Console.WriteLine("{0}'s turn", Players[0].PlayerName);
                }
                else
                {
                    Console.WriteLine("{0}'s turn", Players[1].PlayerName);
                }

                bd.CreateBoard(intro);
                intro = false;
                
                while (!int.TryParse(Console.ReadLine(), out playerPick))
                {
                    Console.WriteLine("Not valid ");
                }
                
                TakeTurn(currentTurn, playerPick, bd);
                currentTurn++;
                
                ValidateResults(bd);
                
                if (GameStatus == 1)
                {
                    Console.WriteLine("SOMEONE WON! {0}", currentTurn);
                }

                if (GameStatus == -1)
                {
                    Console.WriteLine("DRAW");
                }
            }
        }

        private int StartGame( int playerCount)
        {
            var rnd = new Random();
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
           
            Console.WriteLine("Lets get started, press a key when you are ready to move on");

            Console.ReadKey();
            Console.Clear();
            
            Console.Write("Randomizing who will start... \n");

            int playerIdToStart = rnd.Next(0, playerCount+1);
                    
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
            
            return playerIdToStart; 
        }

        private void TakeTurn( int currentTurn, int FieldPicked, Board bd)
        {
            if (bd.Fields[FieldPicked].FieldState != "X" && bd.Fields[FieldPicked].FieldState != "O")
            {
                //if the turn is player 2 then mark O else mark X  
                if (currentTurn % 2 == 0) 
                {
                    bd.Fields[FieldPicked].FieldState = "O";
                }
                else
                {
                    bd.Fields[FieldPicked].FieldState = "X";
                }
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
            if (bd.Fields[1].FieldState == bd.Fields[2].FieldState && bd.Fields[2].FieldState == bd.Fields[3].FieldState)
            {
                GameStatus = 1;
            }

            // Second Row 4/5/6
            else if (bd.Fields[4].FieldState == bd.Fields[5].FieldState && bd.Fields[5].FieldState == bd.Fields[6].FieldState)
            {
                GameStatus = 1;
            }

            // Third Row 6/7/8
            else if (bd.Fields[6].FieldState == bd.Fields[7].FieldState && bd.Fields[7].FieldState == bd.Fields[8].FieldState)
            {
                GameStatus = 1;
            }
                
            // First Column 1/4/7
            else if (bd.Fields[1].FieldState == bd.Fields[4].FieldState && bd.Fields[4].FieldState == bd.Fields[7].FieldState)
            {
                GameStatus = 1;
            }

            // Second Column 2/5/8
            else if (bd.Fields[2].FieldState == bd.Fields[5].FieldState && bd.Fields[5].FieldState == bd.Fields[8].FieldState)
            {
                GameStatus = 1;
            }

            // Third Column 3/6/9

            else if (bd.Fields[3].FieldState == bd.Fields[6].FieldState && bd.Fields[6].FieldState == bd.Fields[9].FieldState)
            {
                GameStatus = 1;
            }

            // Diagonally 1/5/9
            else if (bd.Fields[1].FieldState == bd.Fields[5].FieldState && bd.Fields[5].FieldState == bd.Fields[9].FieldState)
            {
                GameStatus = 1;
            }

            // Diagonally 3/5/7
            else if (bd.Fields[3].FieldState == bd.Fields[5].FieldState && bd.Fields[5].FieldState == bd.Fields[7].FieldState)
            {
                GameStatus = 1;
            }
                
            // Draw

            else if (bd.Fields[1].FieldState != "1" && bd.Fields[2].FieldState != "2" && bd.Fields[3].FieldState != "3" && bd.Fields[4].FieldState != "4" && bd.Fields[5].FieldState != "5" && bd.Fields[6].FieldState != "6" && bd.Fields[7].FieldState != "7" && bd.Fields[8].FieldState != "8" && bd.Fields[9].FieldState != "9")
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