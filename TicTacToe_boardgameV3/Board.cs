using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_boardgameV3;

namespace TicTacToe_boardgame
{
    //Constructor
    public class Board
    {
        public int BoardID;

        List<Fields> Fields = new List<Fields>();
        
        public char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        //Boad metode der laver boardet
        public void CreateBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");

        }
    }
}