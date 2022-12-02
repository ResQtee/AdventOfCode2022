namespace AdventOfCode.Puzzles.Day_2;

public class RockPaperScissor
{
    /// <summary>Outcome is for player 2.</summary>
    public RpsOutcome RPS(Sign player1Hand, Sign player2Hand)
    {
        if (player1Hand == player2Hand)
        {
            return RpsOutcome.Draw;
        }

        switch (player2Hand)
        {   
            case Sign.Rock:
                return player1Hand == Sign.Scissor ? RpsOutcome.Win: RpsOutcome.Lose;
            case Sign.Paper:
                return player1Hand == Sign.Rock ? RpsOutcome.Win: RpsOutcome.Lose;
            case Sign.Scissor:
                return player1Hand == Sign.Paper ? RpsOutcome.Win: RpsOutcome.Lose;
            case Sign.Invalid:
            default:
                throw new ArgumentOutOfRangeException(nameof(player2Hand), player2Hand, null);
        }
    }

    public Sign RPS(Sign player1Hand, RpsOutcome outcome)
    {
        if (outcome == RpsOutcome.Draw)
        {
            return player1Hand;
        }

        switch (outcome)
        {
            case RpsOutcome.Lose:
                switch (player1Hand)
                {
                    case Sign.Rock:
                        return Sign.Scissor;
                    case Sign.Paper:
                        return Sign.Rock;
                    case Sign.Scissor:
                        return Sign.Paper;
                    case Sign.Invalid:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(player1Hand), player1Hand, null);
                }
            case RpsOutcome.Win:
                switch (player1Hand)
                {
                    case Sign.Rock:
                        return Sign.Paper;
                    case Sign.Paper:
                        return Sign.Scissor;
                    case Sign.Scissor:
                        return Sign.Rock;
                    case Sign.Invalid:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(player1Hand), player1Hand, null);
                }
            default:
                throw new ArgumentOutOfRangeException(nameof(outcome), outcome, null);
        }
    }
}