using System;

namespace TicTacToe_boardgameV3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            string playerPick;

            Console.WriteLine("Enter player 1 name");
            
            name = Console.ReadLine();
            
            Console.WriteLine("Welcome {0} !", name);

            Console.WriteLine("Pick nought or cross:");
            Console.WriteLine("O for nought \nX for cross");

            playerPick = Console.ReadLine();
            
            if (playerPick == "O" || playerPick == "o" || playerPick == "X" || playerPick == "x")
            {
                Console.WriteLine("Valid!");
            } else
            {
                Console.WriteLine("Invalid! ");
            }
             
            Console.WriteLine("You chose {0}", playerPick);

            Player p1 = new Player(name, playerPick);

        }
    }
}