namespace AdventOfCode.Puzzles.Day_11;

public class WorryLevelOperation
{
    public readonly string operation;

    public WorryLevelOperation(string operation)
    {
        this.operation = operation.Trim();
    }
    public ulong Execute(ulong oldValue)
    {
        var splitOperation = operation.Split(" ");

        ulong firstValue = ParseValue(splitOperation[0], oldValue);
        ulong secondValue = ParseValue(splitOperation[2], oldValue);

        return splitOperation[1] switch
        {
            "+" => firstValue + secondValue,
            "*" => firstValue * secondValue,
            _ => throw new ArgumentException("Unknown operation")
        };
    }

    private static ulong ParseValue(string value, ulong oldValue)
    {
        return value == "old" ? oldValue : ulong.Parse(value);
    }
}