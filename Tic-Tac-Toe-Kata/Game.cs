using System;

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
        Board.SetTileAt(x, y, CurrentPlayer);
        CurrentPlayer = GetNextPlayerToPlay();
    }

    private string GetNextPlayerToPlay()
    {
        return CurrentPlayer.Equals("X") ? "O" :  "X";
    }

    public string GetWinner()
    {
        for (int row = 0; row < 3; row++)
        {
            if (Board.RowIsNotEmpty(row) && Board.RowIsFilledWith(row, "X"))
            {
                return "X";
            }   
        }
        return "There is NO WINNER";
    }
}