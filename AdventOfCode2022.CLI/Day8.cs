using AdventOfCode.Puzzles.Day_8;

namespace AdventOfCode2022.CLI;

public class Day8
{
    public static void Print()
    {
        Console.WriteLine("----- Day 8 -----");

        Console.WriteLine("Example 1:");

        var treeMap = RasterisedTreeMap.ReadFromFile(@".\day 8\input\example.txt");
        TreeVisibility treeVisibility = new TreeVisibility();
        Console.WriteLine($"Answer: {treeVisibility.FindAllVisibleTrees(treeMap)} trees.");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        Console.WriteLine($"Answer: ");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        treeMap = RasterisedTreeMap.ReadFromFile(@".\day 8\input\puzzle.txt");
        Console.WriteLine($"Answer: {treeVisibility.FindAllVisibleTrees(treeMap)} trees.");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        Console.WriteLine($"Answer: ");
    }
}