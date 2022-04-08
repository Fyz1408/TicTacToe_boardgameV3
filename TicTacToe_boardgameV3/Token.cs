namespace TicTacToe_boardgameV3
{
    public class Token
    {
        public enum TokenType 
        {
            X,
            O
        }

        private TokenType setTokenType{ get; set; }
        
        public Token(TokenType TokenType)
        {
            setTokenType = TokenType;
        }
        
    }
}