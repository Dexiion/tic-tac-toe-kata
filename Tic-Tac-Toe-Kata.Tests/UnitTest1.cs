using FluentAssertions;
using Tic;

namespace Tic_Tac_Toe_Kata.Tests;

public class Tests
{
    private Game Game;
    [SetUp]
    public void Setup()
    {
        Game = new Game("X");
    }

    [Test]
    public void TrowExceptionIfPlayerTwoStartsPlaying()
    {
        Assert.Throws<PlayerNotAllowedToStartException>(() => { _ = new Game("O"); });
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
}