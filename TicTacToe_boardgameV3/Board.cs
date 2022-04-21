using System;
using System.Collections.Generic;


namespace TicTacToe_boardgameV3
{
    //Constructor
    public class Board
    {
        public List<Field> Fields;
        
        //Boad metode der laver boardet
        public void CreateBoard()
        {
            Fields = new List<Field>();
                    
                for (int i = 0; i <= 9; i++)
                { 
                    Fields.Add(
                        new Field(i)
                    );
                }
            DisplayBoard();
            
        }

        public void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Fields[1].FieldState, Fields[2].FieldState, Fields[3].FieldState);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Fields[4].FieldState, Fields[5].FieldState, Fields[6].FieldState);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Fields[7].FieldState, Fields[8].FieldState, Fields[9].FieldState);
            Console.WriteLine("     |     |      ");
        }
    }
}