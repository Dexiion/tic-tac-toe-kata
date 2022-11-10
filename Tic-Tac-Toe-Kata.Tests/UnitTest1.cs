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

public class Game
{
    private string CurrentPlayer;
    
    public Game(string firstPlayer)
    {
        CurrentPlayer = firstPlayer;

        if (firstPlayer.Equals("O"))
        {
            throw new PlayerNotAllowedToStartException("Player O not allowed to start");
        }
    }

}

public class PlayerNotAllowedToStartException : Exception
{
    public PlayerNotAllowedToStartException(string message) : base(message) {}
}

