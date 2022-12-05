using AdventOfCode.Puzzles.Day_4;
using AdventOfCode.Puzzles.Day_5;

namespace AdventOfCode2022.CLI;

public class Day5
{
    public static void Print()
    {
        Console.WriteLine("----- Day 5 -----");

        Console.WriteLine("Example 1:");
        var cargoDetails = CargoShip.LoadCargo(@".\day 5\input\example.txt");
        var newCargoLayout = CargoShip.UnloadCargo(cargoDetails.cargo, cargoDetails.craneCommands);
        Console.WriteLine($"Answer: Top crates: {newCargoLayout.CrateStacks.Select(stack => stack.Peek())}");

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