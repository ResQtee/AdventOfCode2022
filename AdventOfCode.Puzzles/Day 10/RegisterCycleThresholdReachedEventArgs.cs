namespace AdventOfCode.Puzzles.Day_10;

public class RegisterCycleThresholdReachedEventArgs : EventArgs
{
    public int Cycles { get; set; }
    public int RegisterXValue { get; set; }
}