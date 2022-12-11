namespace AdventOfCode.Puzzles.Day_9;

public class InstructionReader
{
    public List<(Direction direction, int distance)> Read(string fileName)
    {
        var instructions = new List<(Direction direction, int distance)>();
        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }

                    var splitLine = line.Split(" ");
                    Enum.TryParse(splitLine[0], out Direction direction);

                    instructions.Add((direction, int.Parse(splitLine[1])));
                }
            }
        }
        return instructions;
    }
}