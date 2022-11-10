namespace Tic;

public class Game
{
    public string CurrentPlayer;
    
    public Game(string firstPlayer)
    {
        CurrentPlayer = firstPlayer;

        if (firstPlayer.Equals("O"))
        {
            throw new PlayerNotAllowedToStartException("Player O not allowed to start");
        }
    }

    public void PlayNextTurn(int x, int y)
    {
        throw new System.NotImplementedException();
    }
}