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
        
        public Token(char token)
        {
            switch (token)
            {
                case 'x':
                case 'X':
                    setTokenType = TokenType.X;
                return;
                case 'o':
                case 'O':
                    setTokenType = TokenType.O;
                    return;
                default:
                    return;
                
            }
        }
    }
}