namespace AdventOfCode.Puzzles.Day_11;

public class Monkey
{
    public int Id { get; set; }
    public ulong DivisionValue { get; }
    public Monkey? TrueMonkey { get; set; }
    public Monkey? FalseMonkey { get; set; }
    public ulong CommonFactor { get; set; }

    public ulong TimesInspected { get; private set; } = 0;
    
    private readonly IMonkeyInspection inspection;
    private readonly WorryLevelOperation worryLevelOperator;

    public Queue<ulong> WorryLevels { get; }

    public Monkey(List<ulong> worryLevels, IMonkeyInspection inspection, WorryLevelOperation worryLevelOperator, ulong divisionValue)
    {
        WorryLevels = new Queue<ulong>(worryLevels);
        DivisionValue = divisionValue;
        this.inspection = inspection;
        this.worryLevelOperator = worryLevelOperator;
    }

    public void ThrowAllOneAtATime()
    {
        while (WorryLevels.TryDequeue(out var currentWorryLevel))
        {
            TimesInspected++;

            currentWorryLevel = worryLevelOperator.Execute(currentWorryLevel);
            currentWorryLevel = Inspect(currentWorryLevel);

            if (IsWorryLevelDivisibleBy(currentWorryLevel, DivisionValue))
            {
                TrueMonkey?.Catch(currentWorryLevel);
            }
            else
            {
                FalseMonkey?.Catch(currentWorryLevel);
            }
        }
    }

    public void Catch(ulong worryLevel)
    {
        WorryLevels.Enqueue(worryLevel);
    }

    private ulong Inspect(ulong worryLevel)
    {
        worryLevel= inspection.Inspect(worryLevel);
        return worryLevel % CommonFactor;
    }

    private static bool IsWorryLevelDivisibleBy(ulong worryLevel, ulong value) => worryLevel % value == 0;

    public override string ToString()
    {
        return $"Monkey {Id}{Environment.NewLine}" +
               $"\tStarting items: {string.Join(',', WorryLevels.ToList())} {Environment.NewLine}" +
               $"\tOperation: new = {worryLevelOperator.operation}{Environment.NewLine}"+
               $"\tTest: divisible by {DivisionValue}{Environment.NewLine}" +
               $"\t\tIf true: throw to monkey {TrueMonkey.Id}{Environment.NewLine}" +
               $"\t\tIf false: throw to monkey {FalseMonkey.Id}{Environment.NewLine}";
        
    }
}