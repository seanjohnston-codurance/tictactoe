namespace TicTacToe.App;

public class TicTacToeBoard
{
    private string _lastPlayedToken = "O";

    public bool Place(string token, int x, int y)
    {
        if (token == _lastPlayedToken)
            return false;
        
        _lastPlayedToken = token;
        return true;
    }
}