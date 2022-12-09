using AdventOfCode.Puzzles.Day_7;

namespace AdventOfCode2022.CLI;

public class Day7
{
    public static void Print()
    {
        Console.WriteLine("----- Day 7 -----");

        FileSystemBuilder builder = new FileSystemBuilder();
        var fs = builder.BuildFromInput(@".\day 7\input\example.txt");
        var dirs = fs.FlattenDirectories().Where(d=> d.Size <= 100000);
        var totalSize = fs.FlattenDirectories().Where(d => d.Size <= 100000).Sum(d => d.Size);
        Console.WriteLine("Example 1:");
        Console.WriteLine($"Answer: {totalSize}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        var orderedDirs = fs.FlattenDirectories().Where(d => d.Size >= (30000000 - fs.FreeSize)).OrderBy(d => d.Size);
        Console.WriteLine($"Free {orderedDirs.First().Name}");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        fs = builder.BuildFromInput(@".\day 7\input\puzzle.txt");
        totalSize = fs.FlattenDirectories().Where(d => d.Size <= 100000).Sum(d => d.Size);
        Console.WriteLine($"Answer: {totalSize}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        orderedDirs = fs.FlattenDirectories().Where(d => d.Size >= (30000000 - fs.FreeSize)).OrderBy(d => d.Size);
        Console.WriteLine($"Free {orderedDirs.First().Name}");
        Console.WriteLine($"Answer: ");
    }
}