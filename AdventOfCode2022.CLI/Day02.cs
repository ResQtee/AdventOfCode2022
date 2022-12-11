using AdventOfCode.Puzzles.Day_02;

namespace AdventOfCode2022.CLI;

internal class Day02
{
    public static void Print()
    {
        var tournament = new Tournament();
        var strategyGuideOne = new StrategyGuideOne();
        var strategyGuideTwo = new StrategyGuideTwo();

        Console.WriteLine("----- Day 2 -----");
        Console.WriteLine("Example 1:");
        var score = tournament.PlayByGuide(@".\day 02\input\example.txt", strategyGuideOne);
        Console.WriteLine($"Score is {score}");
        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        score = tournament.PlayByGuide(@".\day 02\input\puzzle.txt", strategyGuideOne);
        Console.WriteLine($"Score is {score}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        score = tournament.PlayByGuide(@".\day 02\input\example.txt", strategyGuideTwo);
        Console.WriteLine($"Score is {score}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        score = tournament.PlayByGuide(@".\day 02\input\puzzle.txt", strategyGuideTwo);
        Console.WriteLine($"Score is {score}");

    }
}