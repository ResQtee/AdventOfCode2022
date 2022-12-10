﻿namespace AdventOfCode.Puzzles.Day_8;

public class Tree
{
    public Tree(Position position, int height)
    {
        Position = position;
        Height = height;
    }

    public Position Position { get; }

    public int Height { get; }

    public override string ToString()
    {
        return $"[{Position.XCoordinate},{Position.YCoordinate}] H:{Height}";
    }
}

public class Position
{
    public Position(int xCoordinate, int yCoordinate)
    {
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
    }

    public int XCoordinate { get; }
    public int YCoordinate { get; }
}