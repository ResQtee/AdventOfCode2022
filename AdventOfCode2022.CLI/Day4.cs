using AdventOfCode.Puzzles.Day_4;

namespace AdventOfCode2022.CLI;

public class Day4
{
    public static void Print()
    {
        Console.WriteLine("----- Day 4 -----");
        Console.WriteLine("Example 1:");
        var sectionAssignments = Assignments.GiveAssignmentsFromFile(@".\day 4\input\example.txt");
        int noOfFullyContainedAssignments = Assignments.CountFullyContainedAssignment(sectionAssignments);
        Console.WriteLine($"Fully contained assignments: {noOfFullyContainedAssignments}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        sectionAssignments = Assignments.GiveAssignmentsFromFile(@".\day 4\input\puzzle.txt");
        noOfFullyContainedAssignments = Assignments.CountFullyContainedAssignment(sectionAssignments);
        Console.WriteLine($"Fully contained assignments: {noOfFullyContainedAssignments}");
    }
}