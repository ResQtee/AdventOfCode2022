namespace AdventOfCode.Puzzles.Day_09;

public class Rope
{
    public List<Knot> Knots { get; }

    public Rope(int noOfKnots = 2)
    {
        Knots = new List<Knot>(noOfKnots);
        for (int i = 0; i < noOfKnots; i++)
        {
            Knots.Add(new Knot());
        }
    }

    public void MoveFirstKnot(Direction direction, int distance)
    {
        for (int frameIndex = 0; frameIndex < distance; frameIndex++)
        {
            for (int knotIndex = 0; knotIndex < Knots.Count; knotIndex++)
            {
                if (knotIndex == 0)
                {
                    Knots[knotIndex].Move(direction, 1);
                }
                else
                {
                    // Determine delta x and delta y between this knot and the previous knot.
                    FollowKnot(Knots[knotIndex-1], Knots[knotIndex] );
                }
            }
        }
    }

    private void FollowKnot(Knot head, Knot tail)
    {
        // determine delta x and delta y between head and tail
        var distance = head.Position - tail.Position;

        var absoluteDeltaX = int.Abs(distance.deltaX);
        var absoluteDeltaY = int.Abs(distance.deltaY);

        if (absoluteDeltaX > 1 || absoluteDeltaY > 1)
        {
            // Move, the direction is determined by the delta x and delta y.
            var direction = DetermineDirection(distance.deltaX, distance.deltaY);
            tail.Move(direction, 1);
        }
    }

    private Direction DetermineDirection(int deltaX, int deltaY)
    {
        /*                  dx0,dy+ (U)
         *                     |
         *        (UL) dx-,dy+ | dx+,dy+ (UR)
         *                     |
         *(L) dx-,dy0 ---------|--------- dx+,dy0 (R)
         *                     |
         *        (DL) dx-,dy- | dx+,-dy (DR)
         *                     |
         *                  dx0,dy- (D)
         */

        if (deltaX == 0)
        {
            return deltaY switch
            {
                > 0 => Direction.U,
                < 0 => Direction.D,
                _ => Direction.None
            };
        }

        if (deltaY == 0)
        {
            return deltaX switch
            {
                > 0 => Direction.R,
                < 0 => Direction.L
            };
        }

        if (deltaX > 0)
        {
            return deltaY switch
            {
                > 0 => Direction.UR,
                < 0 => Direction.DR
            };
        }

        if (deltaX < 0)
        {
            return deltaY switch
            {
                > 0 => Direction.UL,
                < 0 => Direction.DL
            };
        }

        return Direction.None;
    }
}