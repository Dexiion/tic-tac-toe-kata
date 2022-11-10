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
}