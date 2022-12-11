namespace AdventOfCode.Puzzles.Day_04;

public class SectionAssignment
{
    public int Min { get; set; }
    public int Max { get; set; }

    public bool Encapsulates(SectionAssignment other)
    {
        return Min <= other.Min && Max >= other.Max;
    }

    public bool IsEncapsulated(SectionAssignment other)
    {
        return other.Min <= Min && other.Max >= Max;
    }

    public bool IsOverlapping(SectionAssignment other)
    {
        return other.Min <= Max && Min <= other.Max;
    }
}