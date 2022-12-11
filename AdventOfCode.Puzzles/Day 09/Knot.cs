namespace AdventOfCode.Puzzles.Day_09;

public class Knot
{
    public List<Position> Path { get; } = new();
    public Position Position { get; private set; } = new();

    public Knot()
    {
        Path.Add(new Position());
    }
    public void Move(Direction direction, int distance)
    {
        /*                  dx0,dy+ (U)
         *                     |
         *        (UL) dx-,dy+ | dx+,dy+ (UR)
         *                     |
         *(L) dx-,dy0 ---------|--------- dx+,dy0 (R)
         *                     |
         *        (DL) dx-,dy- | dx+,dy- (DR)
         *                     |
         *                  dx0,dy- (D)
         */
        int newXPosition = Position.XCoordinate;
        int newYPosition = Position.YCoordinate;

        switch (direction)
        {
            case Direction.None:
                break;
            case Direction.U:
                newYPosition += distance;
                break;
            case Direction.D:
                newYPosition -= distance;
                break;
            case Direction.L:
                newXPosition -= distance;
                break;
            case Direction.R:
                newXPosition += distance;
                break;
            case Direction.UL:
                newXPosition -= distance;
                newYPosition += distance;
                break;
            case Direction.UR:
                newXPosition += distance;
                newYPosition += distance;
                break;
            case Direction.DL:
                newXPosition -= distance;
                newYPosition -= distance;
                break;
            case Direction.DR:
                newXPosition += distance;
                newYPosition -= distance;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        var newPosition = new Position(newXPosition, newYPosition);
        Path.Add(newPosition);

        Position = newPosition;
    }
}