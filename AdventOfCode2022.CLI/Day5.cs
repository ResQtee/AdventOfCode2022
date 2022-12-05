using AdventOfCode.Puzzles.Day_4;
using AdventOfCode.Puzzles.Day_5;

namespace AdventOfCode2022.CLI;

public class Day5
{
    public static void Print()
    {
        Console.WriteLine("----- Day 5 -----");

        Console.WriteLine("Example 1:");
        var cargoDetails = CargoInstructions.LoadCargoInstructions(@".\day 5\input\example.txt");
        var newCargoLayout = CargoInstructions.UnloadCargo(cargoDetails.cargo, cargoDetails.instructions, new CrateMover9000());
        Console.WriteLine($"Answer: Top crates: {newCargoLayout.TopCrates}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        cargoDetails = CargoInstructions.LoadCargoInstructions(@".\day 5\input\example.txt");
        newCargoLayout = CargoInstructions.UnloadCargo(cargoDetails.cargo, cargoDetails.instructions, new CrateMover9001());
        Console.WriteLine($"Answer: Top crates: {newCargoLayout.TopCrates}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        cargoDetails = CargoInstructions.LoadCargoInstructions(@".\day 5\input\puzzle.txt");
        newCargoLayout = CargoInstructions.UnloadCargo(cargoDetails.cargo, cargoDetails.instructions, new CrateMover9000());
        Console.WriteLine($"Answer: Top crates: {newCargoLayout.TopCrates}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        cargoDetails = CargoInstructions.LoadCargoInstructions(@".\day 5\input\puzzle.txt");
        newCargoLayout = CargoInstructions.UnloadCargo(cargoDetails.cargo, cargoDetails.instructions, new CrateMover9001());
        Console.WriteLine($"Answer: Top crates: {newCargoLayout.TopCrates}");
    }
}