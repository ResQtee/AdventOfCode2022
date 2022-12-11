namespace AdventOfCode.Puzzles.Day_02;

public class GuideInterpreter
{
    public static Sign SignFromChar(char sign)
    {
        switch (sign)
        {
            case 'A' or 'X':
                return Sign.Rock;

            case 'B' or 'Y':
                return Sign.Paper;

            case 'C' or 'Z':
                return Sign.Scissor;
        }

        return Sign.Invalid;
    }

    public static RpsOutcome OutcomeFromChar(char outcome)
    {
        switch (outcome)
        {
            case 'A' or 'X':
                return RpsOutcome.Lose;

            case 'B' or 'Y':
                return RpsOutcome.Draw;

            case 'C' or 'Z':
                return RpsOutcome.Win;
        }

        return RpsOutcome.Invalid;
    }
}