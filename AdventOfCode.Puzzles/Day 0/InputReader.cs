namespace AdventOfCode.Puzzles.Day_0
{
    public class InputReader
    {
        public void Read(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}