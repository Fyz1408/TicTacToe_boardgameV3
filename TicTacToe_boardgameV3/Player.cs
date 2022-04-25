using System.Collections.Generic;
namespace TicTacToe_boardgameV3
{
    public class Player
    {
        //Stores the name for the players
        private string name; //field
        public string Name //property
        {
            get { return name; } //get method
            set { name = value; } //set method

        }

        //Inheritance from Token (arve) to get a tokentype
        private Token.TokenType token; //field
        public Token.TokenType Token //property
        {
            get { return token; } //get method
            set { token = value; } //set method
        }

    }
}