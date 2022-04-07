using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_boardgameV3
{
    public class Fields
    {
        public enum fields
        {
            field_Empty = ' ',
            field_X = Token.TokenType.X,
            field_O = Token.TokenType.O,

            //public int FieldID { get; set; }
            //public bool IsFieldEmpty;
        }


        fields fieldState = fields.field_Empty;

        public void fieldstate()
        {
            fieldState = fields.field_Empty;
        }


        public bool isEmpty()
        {
            if (fieldState != fields.field_Empty)
            {
                return false;
            }
            return true;
        }


        public fields GetFieldState()
        {
            return fieldState;
        }


        public void MarkField(Player player)
        {
            if (isEmpty())
            {
                if (player.PlayerType == Token.TokenType.X)
                {
                    fieldState = fields.field_X;
                }
                else
                {
                    fieldState = fields.field_O;
                }
            }
        }
    }

}
