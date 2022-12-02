using AdventOfCode.Puzzles.Day_2;

namespace AdventOfCode2022.CLI;

internal class Day2
{
    public static void Print()
    {
        var tournament = new Tournament();
        var strategyGuideOne = new StrategyGuideOne();
        var strategyGuideTwo = new StrategyGuideTwo();

        Console.WriteLine("----- Day 2 -----");
        Console.WriteLine("Example 1:");
        var score = tournament.PlayByGuide(@".\day 2\input\example.txt", strategyGuideOne);
        Console.WriteLine($"Score is {score}");
        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        score = tournament.PlayByGuide(@".\day 2\input\puzzle.txt", strategyGuideOne);
        Console.WriteLine($"Score is {score}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        score = tournament.PlayByGuide(@".\day 2\input\example.txt", strategyGuideTwo);
        Console.WriteLine($"Score is {score}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        score = tournament.PlayByGuide(@".\day 2\input\puzzle.txt", strategyGuideTwo);
        Console.WriteLine($"Score is {score}");

    }
}