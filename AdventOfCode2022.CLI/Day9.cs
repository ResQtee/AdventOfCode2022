using AdventOfCode.Puzzles.Day_9;

namespace AdventOfCode2022.CLI;

public class Day9
{
    public static void Print()
    {
        Console.WriteLine("----- Day 9 -----");
        var reader = new InstructionReader();
        

        Console.WriteLine("Example 1:");
        var rope = new Rope();
        var instructions = reader.Read(@".\day 9\input\example.txt");
        foreach (var instruction in instructions)
        {
            rope.MoveFirstKnot(instruction.direction, instruction.distance);
        }
        Console.WriteLine($"Answer: Knot 2: #{rope.Knots[1].Path.Distinct().Count()}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        rope = new Rope(10);
        instructions = reader.Read(@".\day 9\input\example2.txt");
        foreach (var instruction in instructions)
        {
            rope.MoveFirstKnot(instruction.direction, instruction.distance);
        }
        Console.WriteLine($"Answer: Knot 10: #{rope.Knots[9].Path.Distinct().Count()}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        rope = new Rope(2);
        instructions = reader.Read(@".\day 9\input\puzzle.txt");
        foreach (var instruction in instructions)
        {
            rope.MoveFirstKnot(instruction.direction, instruction.distance);
        }
        Console.WriteLine($"Answer: Knot 2: #{rope.Knots[1].Path.Distinct().Count()}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        rope = new Rope(10);
        instructions = reader.Read(@".\day 9\input\puzzle.txt");
        foreach (var instruction in instructions)
        {
            rope.MoveFirstKnot(instruction.direction, instruction.distance);
        }
        Console.WriteLine($"Answer: Knot 10: #{rope.Knots[9].Path.Distinct().Count()}");
    }
}