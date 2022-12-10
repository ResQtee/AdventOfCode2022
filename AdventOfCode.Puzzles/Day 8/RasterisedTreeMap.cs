using System.Numerics;

namespace AdventOfCode.Puzzles.Day_8
{
    public class RasterisedTreeMap
    {
        public RasterisedTreeMap(int rows, int columns)
        {
            Grid = new Tree[rows, columns];
        }

        public Tree[,] Grid { get; }
        public int MaxRows => Grid.GetUpperBound(0);
        public int MaxColumns => Grid.GetUpperBound(1);
        
        public static RasterisedTreeMap ReadFromFile(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            var rasterisedTreeMap = new RasterisedTreeMap(lines.Length, lines[0].Length);

            for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < lines[0].Length; columnIndex++)
                {
                    rasterisedTreeMap.Grid[rowIndex, columnIndex] = new Tree(new Position(columnIndex, rowIndex), (int)char.GetNumericValue(lines[rowIndex][columnIndex]));
                }
            }

            return rasterisedTreeMap;
        }
    }
}