namespace AdventOfCode.Puzzles.Day_11;

public class Monkey
{
    /*
        Starting items: 79, 60, 97
        Operation: new = old * old
        Test: divisible by 13
        If true: throw to monkey 1
        If false: throw to monkey 3
    */

    public List<int> WorryLevels { get; set; } = new List<int>();

    public IOperation? Operation { get; set; }

    public bool Divisible { get; set; }
}

public interface IOperation
{
    void Execute("old * old");
}