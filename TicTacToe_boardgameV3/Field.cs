namespace TicTacToe_boardgameV3
{
    //Get and sets the state of the field
    public class Field
    {
        private string fieldState; //field
        public string FieldState //property
        {
            get { return fieldState; } //get method
            set { fieldState = value; } //set method
        }
        
        public Field(int fieldId)
        {
            FieldState = fieldId.ToString();
        }
    } 
}
