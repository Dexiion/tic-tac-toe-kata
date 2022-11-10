using Tic;

namespace Tic_Tac_Toe_Kata.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TrowExceptionIfPlayerTwoStartsPlaying()
    {
        Assert.Throws<PlayerNotAllowedToStartException>(() => { _ = new Game("O"); });
    }
}