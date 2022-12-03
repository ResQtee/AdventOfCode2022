using AdventOfCode.Puzzles.Day_3;

namespace AdventOfCode2022.CLI;

public class Day3
{
    public static void Print()
    {
        var priorityCalculator = new ItemPrioritizer();

        Console.WriteLine("----- Day 3 -----");
        Console.WriteLine("Example 1:");

        var rucksacks = new RucksacksInventoryList().FillRucksacks(@".\day 3\input\example.txt");
        var outOfPlaceItems = rucksacks.Select(rucksack => rucksack.FindOutOfPlaceItem()).ToArray();
        var priorityScore = priorityCalculator.Prioritize(outOfPlaceItems);

        foreach (var item in outOfPlaceItems)
        {
            Console.WriteLine($"Difference: {item} ({priorityCalculator.Prioritize(item)})");
        }

        Console.WriteLine($"Total score: {priorityScore}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        rucksacks = new RucksacksInventoryList().FillRucksacks(@".\day 3\input\puzzle.txt");
        outOfPlaceItems = rucksacks.Select(rucksack => rucksack.FindOutOfPlaceItem()).ToArray();
        priorityScore = priorityCalculator.Prioritize(outOfPlaceItems);
        Console.WriteLine($"Puzzle 1 answer: {priorityScore}");
    }
}