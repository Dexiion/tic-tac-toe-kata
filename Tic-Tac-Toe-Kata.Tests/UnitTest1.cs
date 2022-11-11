using FluentAssertions;
using Tic;

namespace Tic_Tac_Toe_Kata.Tests;

public class Tests
{
    private Game Game;
    [SetUp]
    public void Setup()
    {
        Game = new Game("X", new Board());
    }

    [Test]
    public void TrowExceptionIfPlayerTwoStartsPlaying()
    {
        Assert.Throws<PlayerNotAllowedToStartException>(() => { _ = new Game("O", new Board()); });
    }
    
    [Test]
    public void ShouldChangePlayers()
    {
        const int x = 0;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);

        Game.CurrentPlayer.Should().Be("O");
    }
    
    [Test]
    public void ShouldThrowAnExceptionIfFieldIsAlreadyTaken()
    {
        const int x = 0;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        
        Assert.Throws<FieldAlreadyTakenException>(() => { Game.PlayNextTurn(x, y); });
    }
    
    [Test]
    public void ShouldWinWithThreeXInTopRow()
    {
        const int x = 0;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(2, 0);
        Game.PlayNextTurn(0, 1);
        Game.PlayNextTurn(2, 2);
        Game.PlayNextTurn(0, 2);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeOInTopRow()
    {
        const int x = 2;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 0);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(0, 1);
        Game.PlayNextTurn(2, 2);
        Game.PlayNextTurn(0, 2);

        Game.GetWinner().Should().Be("O");
    }
    
    [Test]
    public void ShouldWinWithThreeXInMiddleRow()
    {
        const int x = 1;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(2, 0);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(2, 2);
        Game.PlayNextTurn(1, 2);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeXInBottomRow()
    {
        const int x = 2;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(1, 0);
        Game.PlayNextTurn(2, 1);
        Game.PlayNextTurn(0, 2);
        Game.PlayNextTurn(2, 2);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeXInLeftColumn()
    {
        const int x = 0;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 2);
        Game.PlayNextTurn(1, 0);
        Game.PlayNextTurn(1, 2);
        Game.PlayNextTurn(2, 0);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeOInLeftColumn()
    {
        const int x = 0;
        const int y = 1;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 0);
        Game.PlayNextTurn(1, 2);
        Game.PlayNextTurn(1, 0);
        Game.PlayNextTurn(2, 2);
        Game.PlayNextTurn(2, 0);

        Game.GetWinner().Should().Be("O");
    }
    
    [Test]
    public void ShouldWinWithThreeXInMiddleColumn()
    {
        const int x = 0;
        const int y = 1;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 2);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(1, 2);
        Game.PlayNextTurn(2, 1);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeXInRightColumn()
    {
        const int x = 0;
        const int y = 2;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 1);
        Game.PlayNextTurn(1, 2);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(2, 2);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeXInRightDiagonal()
    {
        const int x = 0;
        const int y = 0;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 1);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(1, 2);
        Game.PlayNextTurn(2, 2);

        Game.GetWinner().Should().Be("X");
    }
    
    [Test]
    public void ShouldWinWithThreeOInRightDiagonal()
    {
        const int x = 0;
        const int y = 1;
        
        Game.PlayNextTurn(x, y);
        Game.PlayNextTurn(0, 0);
        Game.PlayNextTurn(1, 0);
        Game.PlayNextTurn(1, 1);
        Game.PlayNextTurn(2, 1);
        Game.PlayNextTurn(2, 2);

        Game.GetWinner().Should().Be("O");
    }
}