using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        private string PlayerName;
        private Token.TokenType PlayerType;
        
        public Player(string name, string token ) 
        { 
            PlayerName = name;
            
            if (token == "o" | token == "O") 
            { 
                PlayerType = Token.TokenType.Nought;
            }
            else if (token == "x" | token == "X") 
            { 
                PlayerType = Token.TokenType.Cross; 
            }
        }
    }
}