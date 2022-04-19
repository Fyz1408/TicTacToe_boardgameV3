using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public string Name // property
        {
            get;
            set;
        }

        public Token.TokenType Token{ get; set; }
        
    }
}