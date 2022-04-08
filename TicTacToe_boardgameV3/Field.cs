namespace TicTacToe_boardgameV3
{
    public class Field
    {
        public string FieldState { get; set; }
        
        public Field(int fieldId)
        {
            FieldState = fieldId.ToString();
        }
    }
}
