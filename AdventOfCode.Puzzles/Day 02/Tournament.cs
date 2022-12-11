namespace AdventOfCode.Puzzles.Day_02;

public class Tournament
{
    public int PlayByGuide(string fileName, IStrategyGuide guide)
    {
        int score = 0;

        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    score += guide.CalculateRoundScore(line[0], line[2]);
                } 
            }
        }
        
        return score;
    }
}