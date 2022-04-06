using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public string PlayerName;
        public Token.TokenType PlayerType;
        
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

        public void getPlayerName()
        {
            
            
        } 
        

    }
}