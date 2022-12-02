namespace AdventOfCode.Puzzles.Day_2;

public class StrategyGuideOne : IStrategyGuide
{
    public int CalculateRoundScore(char first, char second)
    {
        var game = new RockPaperScissor();
        var player1Sign = GuideInterpreter.SignFromChar(first);
        var player2Sign = GuideInterpreter.SignFromChar(second);
        var outcome = game.RPS(player1Sign, player2Sign );

        return (int)outcome + (int)player2Sign;
    }
}