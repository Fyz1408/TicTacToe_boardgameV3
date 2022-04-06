using System;
using TicTacToe_boardgame;

namespace TicTacToe_boardgameV3
{
    public class Game
    {
        public Player[] Players;
        
        public Board Board;

        private int GameStatus;

        public Game()
        {
            Board bd = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            
            Console.WriteLine("Welcome to tic tac toe");
                
            Console.WriteLine("Enter player 1 name:");
                
            p1.PlayerName = Console.ReadLine();
                
            Console.WriteLine("Welcome {0} !", p1.PlayerName);
            
            Console.WriteLine("Enter player 2's name:");
            
            p2.PlayerName = Console.ReadLine();
            
            Console.WriteLine("Welcome {0} !", p2.PlayerName);
            
            Console.WriteLine("{0} Will play with noughts: O and {1} will play with crosses: X", p1.PlayerName, p2.PlayerName);
            
            Console.WriteLine("Lets get started, Click when you're ready to play!");

            Console.ReadKey();
            
            Console.Clear();
            
            bd.CreateBoard();

            while (GameStatus != 1 && GameStatus != -1)
            {
                
                
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
        
    }
}