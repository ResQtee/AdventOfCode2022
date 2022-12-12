namespace AdventOfCode.Puzzles.Day_10;

public class CPU
{
    private readonly ClockCircuit clock;

    public event EventHandler<RegisterCycleThresholdReachedEventArgs>? RegisterCycleThresholdReached;

    public int RegisterX { get; private set; }

    public CPU(ClockCircuit clock)
    {
        this.clock = clock;
        RegisterX = 1;

        clock.CycleThresholdReached += OnClockOnCycleThresholdReached;
    }

    private void OnClockOnCycleThresholdReached(object? sender, CycleThresholdReachedEventArgs e)
    {
        //Console.WriteLine($"C:{e.Cycles} | X:{RegisterX}");

        RegisterCycleThresholdReached?.Invoke(this, 
            new RegisterCycleThresholdReachedEventArgs { Cycles = e.Cycles, RegisterXValue = RegisterX });
    }

    // Instruction Set.

    public int AddX(int x)
    {
        //Console.WriteLine($"Add {x}");
        clock.Cycle();
        clock.Cycle();

        RegisterX += x;

        return RegisterX;
    }

    public void NoOp()
    {
        //Console.WriteLine($"Noop");
        clock.Cycle();
    }
}