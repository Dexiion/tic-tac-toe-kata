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
        for (int N = 0; N < 3; N++)
        {
            if (Board.RowIsNotEmpty(N) && Board.RowIsFilledWith(N, "X"))
            {
                return "X";
            }
            
            if (Board.RowIsNotEmpty(N) && Board.RowIsFilledWith(N, "O"))
            {
                return "O";
            }

            if (Board.ColumnIsNotEmpty(N) && Board.ColumnIsFilledWith(N, "X"))
            {
                return "X";
            }
            
            if (Board.ColumnIsNotEmpty(N) && Board.ColumnIsFilledWith(N, "O"))
            {
                return "O";
            }
            
        }

        if (Board.RightDiagonalIsNotEmpty() && Board.RightDiagonalIsFilledWith("X"))
        {
            return "X";
        }
        
        if (Board.RightDiagonalIsNotEmpty() && Board.RightDiagonalIsFilledWith("O"))
        {
            return "O";
        }
        
        if (Board.LeftDiagonalIsNotEmpty() && Board.LeftDiagonalIsFilledWith("X"))
        {
            return "X";
        }
        
        return "There is NO WINNER";
    }
}