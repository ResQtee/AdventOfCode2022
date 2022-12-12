using AdventOfCode.Puzzles.Day_10;

namespace AdventOfCode2022.CLI;

public class Day10
{
    public static void Print()
    {
        Console.WriteLine("----- Day 10 -----");

        var clock = new ClockCircuit();
        var cpu = new CPU(clock);
        var total = 0;
        cpu.RegisterCycleThresholdReached += delegate(object? sender, RegisterCycleThresholdReachedEventArgs args)
        {
            total += args.Cycles * args.RegisterXValue;
        };

        var ip = new InstructionProcessor();
        ip.Execute(@".\day 10\input\example.txt",cpu);

        Console.WriteLine("Example 1:");
        Console.WriteLine($"Answer: {total}");

        Console.WriteLine();
        Console.WriteLine("Example 2:");
        Console.WriteLine($"Answer: ");

        clock = new ClockCircuit();
        cpu = new CPU(clock);
        total = 0;
        cpu.RegisterCycleThresholdReached += delegate (object? sender, RegisterCycleThresholdReachedEventArgs args)
        {
            total += args.Cycles * args.RegisterXValue;
        };

        ip = new InstructionProcessor();
        ip.Execute(@".\day 10\input\puzzle.txt", cpu);

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        Console.WriteLine($"Answer: {total}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        Console.WriteLine($"Answer: ");
    }

    private static void CpuOnRegisterCycleThresholdReached(object? sender, RegisterCycleThresholdReachedEventArgs e)
    {
        throw new NotImplementedException();
    }
}