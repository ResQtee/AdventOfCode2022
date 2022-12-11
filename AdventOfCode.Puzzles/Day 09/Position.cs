namespace AdventOfCode.Puzzles.Day_09;

public record Position
{
    public int XCoordinate { get; }
    public int YCoordinate { get; }

    public Position()
    {
        XCoordinate = 0;
        YCoordinate = 0;
    }

    public Position(int xCoordinate, int yCoordinate)
    {
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
    }

    public static (int deltaX, int deltaY) operator -(Position a, Position b)
    {
        return (a.XCoordinate - b.XCoordinate, a.YCoordinate - b.YCoordinate);
    }
}