namespace AdventOfCode.Puzzles.Day_7;

public class FileSystemBuilder
{
    public FileSystem BuildFromInput(string fileName)
    {
        var fileSystem = new FileSystem();

        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();

                    if (line.StartsWith("$"))
                    {
                        var splitCommandString = line.Split(" ");
                        var command = splitCommandString[1];

                        if (command.Equals("cd", StringComparison.OrdinalIgnoreCase))
                        {
                            var cdCommand = new ChangeDirectoryCommand();
                            cdCommand.Execute(fileSystem, splitCommandString[2]);
                        }

                        else if (command.Equals("ls", StringComparison.OrdinalIgnoreCase))
                        {
                            // as long as there is no new command process ls command.
                            while (!streamReader.EndOfStream && !streamReader.Peek().Equals('$'))
                            {
                                var lsLine = streamReader.ReadLine();

                                if (lsLine == null)
                                {
                                    break;
                                }

                                var splitLsLine = lsLine.Split(" ");
                                if (splitLsLine[0].Equals("dir", StringComparison.OrdinalIgnoreCase))
                                {
                                    fileSystem.CurrentDirectory.Add(new SystemDirectory(splitLsLine[1]));
                                }
                                else
                                {
                                    fileSystem.CurrentDirectory.Add(new SystemFile(splitLsLine[1],
                                        int.Parse(splitLsLine[0])));
                                }
                            }
                        }
                    }
                }
            }
        }

        return fileSystem;
    }
}