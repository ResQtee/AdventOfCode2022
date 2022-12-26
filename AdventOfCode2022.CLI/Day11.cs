using AdventOfCode.Puzzles.Day_11;

namespace AdventOfCode2022.CLI;

public class Day11
{
    public static void Print()
    {
        Console.WriteLine("----- Day 11 -----");
        var ir = new InputReader();

        Console.WriteLine("Example 1:");
        var monkeyTroop = ir.Read(@".\day 11\input\example.txt", new ReliefMonkeyInspection());
        monkeyTroop.Rounds(20);
        Console.WriteLine($"Answer: {monkeyTroop.TwoHighestInspections()}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        var monkeyTroop2 = ir.Read(@".\day 11\input\example.txt", new NoReliefMonkeyInspection());
        monkeyTroop2.Rounds(10000);
        Console.WriteLine($"Answer: {monkeyTroop2.TwoHighestInspections()}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        monkeyTroop = ir.Read(@".\day 11\input\puzzle.txt", new ReliefMonkeyInspection());
        monkeyTroop.Rounds(20);
        Console.WriteLine($"Answer: {monkeyTroop.TwoHighestInspections()}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        monkeyTroop2 = ir.Read(@".\day 11\input\puzzle.txt", new NoReliefMonkeyInspection());
        monkeyTroop2.PrintTroop();
        monkeyTroop2.Rounds(10000);
        Console.WriteLine($"Answer: {monkeyTroop2.TwoHighestInspections()}");
    }
}