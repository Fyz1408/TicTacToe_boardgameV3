﻿using System;
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

        List<Field> Fields = new List<Field>();
        
        public char[] arr = { '1', '2', '3', '3', '4', '5', '6', '7', '8', '9' };

        //Boad metode der laver boardet
        public void CreateBoard()
        {
            Console.WriteLine("     |    |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
            Console.WriteLine("     |    |     ");
            Console.WriteLine("     |    |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
            Console.WriteLine("     |    |     ");
            Console.WriteLine("     |    |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |    |     ");

        }
    }
}