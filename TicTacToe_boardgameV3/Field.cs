namespace TicTacToe_boardgameV3
{
    //Get and sets the state of the field
    public class Field
    {
        public string FieldState { get; set; }
        
        public Field(int fieldId)
        {
            FieldState = fieldId.ToString();
        }
    } 
}
