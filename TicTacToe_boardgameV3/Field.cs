namespace TicTacToe_boardgameV3
{
    public class Field
    {
        public int FieldId;
        
        public string FieldState { get; set; }
        
        public Field(int fieldID)
        {
            FieldState = fieldID.ToString();
            FieldId = fieldID;
        }
    }
}
