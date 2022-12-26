namespace AdventOfCode.Puzzles.Day_11;

public interface IMonkeyInspection
{
    public ulong Inspect(ulong worryLevel);
}

public class ReliefMonkeyInspection : IMonkeyInspection
{
    public ulong Inspect(ulong worryLevel)
    {
        return (ulong)(worryLevel / 3.0);
    }
}

public class NoReliefMonkeyInspection : IMonkeyInspection
{
    public ulong Inspect(ulong worryLevel)
    {
        return worryLevel;
    }
}