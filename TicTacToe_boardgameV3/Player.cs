using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public List<Token> PlayerTokens;
        
        public string Name { get; set; }
        
        public void AddTokens(int tokenAmount, Token.TokenType tokenType)
        {
            PlayerTokens = new List<Token>();
                    
            for (int i = 0; i <= tokenAmount; i++)
            { 
                PlayerTokens.Add(new Token(tokenType)
                );
            }
        }
        
        public char GetTokenType()
        {
            return 'x';
        }
    }
}