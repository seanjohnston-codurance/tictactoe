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
}