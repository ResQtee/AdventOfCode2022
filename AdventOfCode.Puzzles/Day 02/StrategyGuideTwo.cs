namespace AdventOfCode.Puzzles.Day_02;

public class StrategyGuideTwo : IStrategyGuide
{
    public int CalculateRoundScore(char first, char second)
    {
        var game = new RockPaperScissor();
        var player1Sign = GuideInterpreter.SignFromChar(first);
        var outcome = GuideInterpreter.OutcomeFromChar(second);
        var player2Sign = game.RPS(player1Sign, outcome);

        return (int)outcome + (int)player2Sign;
    }
}