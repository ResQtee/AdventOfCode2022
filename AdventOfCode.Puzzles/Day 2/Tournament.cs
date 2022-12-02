using AdventOfCode.Puzzles.Day_1;
using static System.Formats.Asn1.AsnWriter;

namespace AdventOfCode.Puzzles.Day_2;

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