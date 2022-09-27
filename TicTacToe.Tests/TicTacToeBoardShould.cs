using TicTacToe.App;

namespace TicTacToe.Tests;

public class TicTacToeBoardShould
{
    private const string X = "X";
    private const string O = "O";
    
    private readonly TicTacToeBoard _ticTacToe;

    public TicTacToeBoardShould()
    {
        _ticTacToe = new TicTacToeBoard();
    }

    [Fact]
    public void RequireXToGoFirst()
    {
        Assert.True(_ticTacToe.Place(X, 0, 0));
    }

    [Fact]
    public void NotAllowOToGoFirst()
    {
        Assert.False(_ticTacToe.Place(O, 0, 0));
    }

    [Fact]
    public void NotAllowSamePlayerToPlayTwiceInARow()
    {
        _ticTacToe.Place(X, 0, 0);
        
        Assert.False(_ticTacToe.Place(X, 0, 0));
    }

    [Fact]
    public void AllowPlayersToPlayInAlternatingTurns()
    {
        _ticTacToe.Place(X, 0, 0);
        
        Assert.True(_ticTacToe.Place(O, 0, 0));
    }
}