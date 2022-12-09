using System.Linq;

namespace AdventOfCode.Puzzles.Day_7
{
    public class FileSystem
    {
        private int FileSystemSize = 70000000;

        private readonly SystemDirectory root = new("/");

        public FileSystem()
        {
            CurrentDirectory = root;
        }

        public SystemDirectory CurrentDirectory { get; set; }

        public SystemDirectory Root => root;

        public int FreeSize => FileSystemSize - root.Size;

        public List<IFileSystemItem> FlattenDirectories()
        {
            var directories = new List<IFileSystemItem>();
            Flatten(directories, root);

            return directories;
        }

        private void Flatten(List<IFileSystemItem> flattenedDirectories, SystemDirectory dir)
        {
            var subDirectories = dir.FileSystemItems.Where(item => item.GetType() == typeof(SystemDirectory)).ToList();
            foreach (var subDirectory in subDirectories)
            {
                Flatten(flattenedDirectories, (SystemDirectory)subDirectory);
            }

            if (subDirectories.Any())
            {
                flattenedDirectories.AddRange(subDirectories);
            }
        }
    }

    public class SystemDirectory : IFileSystemItem
    {
        private readonly List<IFileSystemItem> fileSystemItems = new();

        public SystemDirectory(string name)
        {
            Name = name;
        }

        public SystemDirectory? ParentDirectory { get; set; }

        public IReadOnlyList<IFileSystemItem> FileSystemItems => fileSystemItems.AsReadOnly();

        public string Name { get; set; }

        public int Size => FileSystemItems.Sum(fsi => fsi.Size);

        public void Add(IFileSystemItem item)
        {
            if (item.GetType() == typeof(SystemDirectory))
            {
                ((SystemDirectory)item).ParentDirectory = this;
            }

            fileSystemItems.Add(item);
        }
    }

    public class SystemFile : IFileSystemItem
    {
        public SystemFile(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public string Name { get; set; }
        public int Size { get; }
    }

    public interface IFileSystemItem
    {
        string Name { get; set; }
        int Size { get; }
    }
}