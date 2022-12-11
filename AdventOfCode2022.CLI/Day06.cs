using AdventOfCode.Puzzles.Day_06;

namespace AdventOfCode2022.CLI;

public class Day06
{
    public static void Print()
    {
        Console.WriteLine("----- Day 6 -----");
        
        Console.WriteLine("Example 1:");
        InputReader reader = new InputReader();
        var window = reader.FindWindow(@".\day 06\input\example.txt");
        Console.WriteLine($"Answer: {new string(window.window)}:{window.index}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        window = reader.FindWindow(@".\day 06\input\puzzle.txt");
        Console.WriteLine($"Answer: {new string(window.window)}:{window.index}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        Console.WriteLine($"Answer: ");
    }
}