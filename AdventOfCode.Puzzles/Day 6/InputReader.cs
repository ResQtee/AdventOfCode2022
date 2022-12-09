namespace AdventOfCode.Puzzles.Day_6
{
    public class InputReader
    {
        public (string window, int index) FindWindow(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                string? window = string.Empty;
                int index = -1;
                
                using (var streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        index = -1;
                        var line = streamReader.ReadLine();
                        // sliding window.
                        do
                        {
                            index++;
                            window = line?.Substring(index, 14);
                        } while (window?.Distinct().Count() < 14);

                        Console.WriteLine($"Answer: {new string(window)}: {index+14}");
                    }
                }
                return (window, index+4);
            }
        }
    }
}