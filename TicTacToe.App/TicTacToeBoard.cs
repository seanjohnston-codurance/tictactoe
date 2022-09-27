namespace TicTacToe.App;

public class TicTacToeBoard
{
    private char _lastPlayedToken = 'O';
    private char[,] _playedPositions = new char[3, 3]; 

    public bool Place(char token, int x, int y)
    {
        if (token == _lastPlayedToken)
            return false;

        if (_playedPositions[x, y] == 'X' || _playedPositions[x,y] == 'O')
            return false;

        _playedPositions[x, y] = token;
        _lastPlayedToken = token;
        return true;
    }
}