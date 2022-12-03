namespace AdventOfCode.Puzzles.Day_3;

public class Compartment
{
    public IEnumerable<char> Items { get; set; } = new List<char>();

    public IEnumerable<char> DifferentItemTypes => Items.Distinct().ToArray();
}