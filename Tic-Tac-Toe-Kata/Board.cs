namespace Tic;

public class Board
{
    private string[,] Matrix;

    public Board()
    {
        Matrix = new[,]
        {
            {"-","-","-"},
            {"-","-","-"},
            {"-","-","-"}
        };
    }

    public void SetTileAt(int x, int y, string tile)
    {
        if (FieldIsNotEmpty(x, y)) throw new FieldAlreadyTakenException($"Field {x}-{y} is already taken");

        Matrix[x, y] = tile;
    }

    private bool FieldIsNotEmpty(int x, int y)
    {
        return Matrix[x, y] != "-";
    }

    public bool RowIsNotEmpty(int row)
    {
        return !Matrix[row, 0].Equals("-") && !Matrix[row, 1].Equals("-") && !Matrix[row, 2].Equals("-");
    }

    public bool RowIsFilledWith(int row, string player)
    {
        return Matrix[row, 0].Equals(player) && Matrix[row, 1].Equals(player) && Matrix[row, 2].Equals(player);
    }

    public bool ColumnIsFilledWith(int column, string player)
    {
        return Matrix[0, column].Equals(player) && Matrix[1, column].Equals(player) && Matrix[2, column].Equals(player);
    }

    public bool ColumnIsNotEmpty(int column)
    {
        return !Matrix[0, column].Equals("-") && !Matrix[1, column].Equals("-") && !Matrix[2, column].Equals("-");
    }
}