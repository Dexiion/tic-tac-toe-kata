namespace Tic;

public class Game
{
    public string CurrentPlayer { get; set; }
    private Board Board;
    
    public Game(string firstPlayer, Board board)
    {
        CurrentPlayer = firstPlayer;
        Board = board;

        if (firstPlayer.Equals("O"))
        {
            throw new PlayerNotAllowedToStartException("Player O not allowed to start");
        }
    }

    public void PlayNextTurn(int x, int y)
    {
        CurrentPlayer = GetNextPlayerToPlay();
        Board.SetTileAt(x, y, CurrentPlayer);

    }

    private string GetNextPlayerToPlay()
    {
        return CurrentPlayer.Equals("X") ? "O" :  "X";
    }
}