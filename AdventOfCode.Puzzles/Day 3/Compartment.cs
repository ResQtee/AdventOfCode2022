namespace AdventOfCode.Puzzles.Day_3;

public class Compartment
{
    public string Items { get; set; }

    public char[] DifferentItemTypes => Items.Distinct().ToArray();
}