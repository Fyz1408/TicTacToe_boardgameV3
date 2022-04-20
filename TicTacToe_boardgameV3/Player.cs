using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        //Stores the name for the players
        public string Name
        {
            get;
            set;
        }

        //Inheritance from Token (arve) to get a tokentype
        public Token.TokenType Token
        {
            get; 
            set;
        }
        
    }
}