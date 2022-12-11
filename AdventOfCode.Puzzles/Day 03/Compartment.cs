namespace AdventOfCode.Puzzles.Day_03;

public class Compartment
{
    public IEnumerable<char> Items { get; set; } = new List<char>();

    public IEnumerable<char> DifferentItemTypes => Items.Distinct().ToArray();
}