namespace Tic;

public class Game
{
    public string CurrentPlayer { get; set; }
    
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
        CurrentPlayer = GetNextPlayerToPlay();
    }

    private string GetNextPlayerToPlay()
    {
        return CurrentPlayer.Equals("X") ? "O" :  "X";
    }
}