using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public int PlayerID { get; set; }
        
        public string PlayerName { get; set; }
        
        public Token.TokenType PlayerType;
        
        public Player(int playerId)
        {
            PlayerID = playerId;

        } 
        

    }
}