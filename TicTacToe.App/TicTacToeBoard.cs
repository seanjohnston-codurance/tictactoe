namespace TicTacToe.App;

public class TicTacToeBoard
{
    public bool Place(string token, int x, int y)
    {
        if (token == "O") 
            return false;
        return true;
    }
}