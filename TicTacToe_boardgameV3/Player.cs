using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public Token.TokenType PlayerToken { get; set; }
        
        public List<Token> PlayerTokens;
        
        public string Name { get; set; }

        public char getTokenType()
        {
            // get token type
            return 'x';
        }
        
        public void AddTokens(int tokenAmount, char tokenType)
        {
            PlayerTokens = new List<Token>(tokenType);
                    
            for (int i = 0; i <= tokenAmount; i++)
            { 
                PlayerTokens.Add(new Token(tokenType)
                );
            }
        }
    }
}