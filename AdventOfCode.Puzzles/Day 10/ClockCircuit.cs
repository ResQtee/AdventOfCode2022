namespace AdventOfCode.Puzzles.Day_10;

public class ClockCircuit
{
    public event EventHandler<CycleThresholdReachedEventArgs>? CycleThresholdReached;
        
    public int CycleId { get; private set; } = 0;

    private readonly List<int> cycleEventTriggers = new() { 20, 60, 100, 140, 180, 220 };

    public void Cycle()
    {
        CycleId++;

        if (cycleEventTriggers.Contains(CycleId))
        {
            var args = new CycleThresholdReachedEventArgs
            {
                Cycles = CycleId
            };
            OnCycleThresholdReached(args);
        }
    }

    private void OnCycleThresholdReached(CycleThresholdReachedEventArgs e)
    {
        CycleThresholdReached?.Invoke(this, e);
    }
}