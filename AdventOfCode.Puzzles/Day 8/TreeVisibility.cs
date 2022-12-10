namespace AdventOfCode.Puzzles.Day_8;

public class TreeVisibility
{
    public int FindAllVisibleTrees(RasterisedTreeMap treeMap)
    {
        var visibleTrees = new List<Tree>();

        for (int i = 0; i <= treeMap.MaxRows; i++)
        {
            for (int j = 0; j <= treeMap.MaxColumns; j++)
            {
                var tree = treeMap.Grid[i, j];
                if (IsVisibleFromNorth(treeMap, tree))
                {
                    Console.WriteLine($"[{i},{j} = {treeMap.Grid[i, j].Height}] V: North");
                    visibleTrees.Add(tree);
                }
                else if (IsVisibleFromEast(treeMap, tree))
                {
                    Console.WriteLine($"[{i},{j} = {treeMap.Grid[i, j].Height}] V: East");
                    visibleTrees.Add(tree);
                }
                else if (IsVisibleFromSouth(treeMap, tree))
                {
                    Console.WriteLine($"[{i},{j} = {treeMap.Grid[i, j].Height}] V: South");
                    visibleTrees.Add(tree);
                }
                else if (IsVisibleFromWest(treeMap, tree))
                {
                    Console.WriteLine($"[{i},{j} = {treeMap.Grid[i, j].Height}] V: West");
                    visibleTrees.Add(tree);
                }
            }
        }

        return visibleTrees.Count;
    }

    public bool IsVisibleFromNorth(RasterisedTreeMap treeMap, Tree tree)
    {
        var visible = true;
            
        var rowIndex = tree.Position.YCoordinate;
        var columnIndex = tree.Position.XCoordinate;

        while (visible && rowIndex > 0)
        {
            rowIndex--; // north = up in column -> y--
            visible = treeMap.Grid[rowIndex, columnIndex].Height < tree.Height;
        } 

        return visible;
    }

    public bool IsVisibleFromSouth(RasterisedTreeMap treeMap, Tree tree)
    {
        var visible = true;

        var rowIndex = tree.Position.YCoordinate;
        var columnIndex = tree.Position.XCoordinate;

        while (visible && rowIndex < treeMap.MaxRows)
        {
            rowIndex++; // South = down in column -> y++
            visible = treeMap.Grid[rowIndex, columnIndex].Height < tree.Height;
        }

        return visible;
    }

    public bool IsVisibleFromEast(RasterisedTreeMap treeMap, Tree tree)
    {
        var visible = true;

        var rowIndex = tree.Position.YCoordinate;
        var columnIndex = tree.Position.XCoordinate;

        while (visible && columnIndex < treeMap.MaxColumns)
        {
            columnIndex++; // East = right in row -> x++
            visible = treeMap.Grid[rowIndex, columnIndex].Height < tree.Height;
        }

        return visible;
    }

    public bool IsVisibleFromWest(RasterisedTreeMap treeMap, Tree tree)
    {
        var visible = true;

        var rowIndex = tree.Position.YCoordinate;
        var columnIndex = tree.Position.XCoordinate;

        while (visible && columnIndex > 0)
        {
            columnIndex--; // West = left in row -> x--
            visible = treeMap.Grid[rowIndex, columnIndex].Height < tree.Height;
        }

        return visible;
    }
}