using TicTacToe.App;

namespace TicTacToe.Tests;

public class TicTacToeBoardShould
{
    [Fact]
    public void RequireXToGoFirst()
    {
        var ticTacToe = new TicTacToeBoard();
        Assert.True(ticTacToe.Place("X", 0, 0));
    }

    [Fact]
    public void NotAllowOToGoFirst()
    {
        var ticTacToe = new TicTacToeBoard();
        Assert.False(ticTacToe.Place("O", 0, 0));
    }
}