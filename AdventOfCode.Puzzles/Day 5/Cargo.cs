namespace AdventOfCode.Puzzles.Day_5;

public class Cargo
{
    public List<Stack<char>> CrateStacks { get; set; } = new List<Stack<char>>();

    public string TopCrates => new(CrateStacks.Select(stack => stack.Peek()).ToArray());
}