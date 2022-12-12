namespace AdventOfCode.Puzzles.Day_10
{
    public class InstructionProcessor
    {
        public void Execute(string fileName, CPU cpu)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();

                        if (line.StartsWith("noop",StringComparison.OrdinalIgnoreCase))
                        {
                            cpu.NoOp();
                        }

                        else if (line.StartsWith("AddX", StringComparison.OrdinalIgnoreCase))
                        {
                            cpu.AddX(int.Parse(line.Split(" ")[1]));
                        }
                    }
                }
            }
        }
    }
}