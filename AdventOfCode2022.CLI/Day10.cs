using AdventOfCode.Puzzles.Day_10;

namespace AdventOfCode2022.CLI;

public class Day10
{
    public static void Print()
    {
        Console.WriteLine("----- Day 10 -----");

        var clock = new ClockCircuit();
        var cpu = new CPU(clock);

        var ip = new InstructionProcessor();
        ip.Execute(@".\day 10\input\example.txt",cpu);

        Console.WriteLine("Example 1:");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        Console.WriteLine($"Answer: ");
    }
}