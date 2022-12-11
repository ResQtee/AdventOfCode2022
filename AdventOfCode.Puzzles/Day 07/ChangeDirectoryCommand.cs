namespace AdventOfCode.Puzzles.Day_07;

public class ChangeDirectoryCommand
{
    public FileSystem Execute(FileSystem fileSystem, string args)
    {
        if (args == "..")
        {
            if (fileSystem.CurrentDirectory.ParentDirectory == null)
            {
                throw new ArgumentOutOfRangeException(args, "Can't change directory, root directory reached");
            }
            else
            {
                fileSystem.CurrentDirectory = fileSystem.CurrentDirectory.ParentDirectory;
            }
        }
        else if (args == "/")
        {
            fileSystem.CurrentDirectory = fileSystem.Root;
        }
        else
        {
            var targetDirectory = fileSystem.CurrentDirectory.FileSystemItems.FirstOrDefault(item => item.Name == args && item.GetType() == typeof(SystemDirectory));
            if (targetDirectory == null)
            {
                throw new ArgumentOutOfRangeException(args, "Directory doesn't exist");
            }

            fileSystem.CurrentDirectory = (SystemDirectory)targetDirectory;
        }

        return fileSystem;
    }
}