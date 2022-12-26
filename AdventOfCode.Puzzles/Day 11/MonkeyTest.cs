namespace AdventOfCode.Puzzles.Day_11;

public class MonkeyTest
{
    public MonkeyTest(int divisibleByValue, Monkey testTrueMonkey, Monkey testFalseMonkey)
    {
        DivisionTestValue = divisibleByValue;
        TestTrueMonkey = testTrueMonkey;
        TestFalseMonkey = testFalseMonkey;
    }
    public int DivisionTestValue { get; set; }
    public Monkey TestTrueMonkey { get; }
    public Monkey TestFalseMonkey { get; }

    public Monkey Throw()
    {
        return IsDivisibleBy(DivisionTestValue) ? TestTrueMonkey : TestFalseMonkey;
    }

    private bool IsDivisibleBy(int value)
    {
        return DivisionTestValue % value == 0;
    }
}