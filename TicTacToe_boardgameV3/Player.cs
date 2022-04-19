using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        public List<Token> PlayerTokens;

        public string Name // property
        {
            get;
            set;
        }

        public void AddTokens(int tokenAmount, Token.TokenType tokenType)
        {
            PlayerTokens = new List<Token>();
                    
            for (int i = 0; i <= tokenAmount; i++)
            { 
                PlayerTokens.Add(new Token(tokenType)
                );
            }
        }
        
        public Token.TokenType Token{ get; set; }
        
        public char GetTokenType()
        {
            return 'x';
        }
    }
}