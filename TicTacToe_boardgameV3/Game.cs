using System;
using TicTacToe_boardgame;

namespace TicTacToe_boardgameV3
{
    public class Game
    {
        public Player[] Players;
        
        public Board Board;

        public Game()
        {
            string player1Name;
            string player2Name;
            string player1Pick;
            string player2Pick;

            Console.WriteLine("Enter player 1 name");
            
            player1Name = Console.ReadLine();
            
            Console.WriteLine("Welcome {0} !", player1Name);
            
            Console.WriteLine("Enter player 2 name");
            
            player2Name = Console.ReadLine();
            
            Console.WriteLine("Welcome {0} !", player2Name);
            
            Console.WriteLine("Now {0}, Pick nought or cross:", player1Name);
            Console.WriteLine("O for nought \nX for cross");

            player1Pick = Console.ReadLine();
            
            if (player1Pick == "O" || player1Pick == "o" )
            {
                Console.WriteLine("Valid!");
                player2Pick = "x";
            } else if (player1Pick == "X" || player1Pick == "x")
            {
                Console.WriteLine("Valid!");
                player2Pick = "o";
            }
            else
            {
                Console.WriteLine("Invalid! ");
                return;
            }
            
            Console.WriteLine("{0} chose {1}", player1Name, player1Pick);
            Console.WriteLine("That means {0} will play with {1}", player2Name, player2Pick);

            var p1 = new Player(player1Name, player1Pick);
            var p2 = new Player(player1Name, player1Pick);

            Console.WriteLine(p1.PlayerName);
            Console.WriteLine(p1.PlayerType);
            Console.WriteLine(p2.PlayerName);
            Console.WriteLine(p2.PlayerType);
            
            Console.ReadKey();

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