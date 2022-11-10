namespace Tic;

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