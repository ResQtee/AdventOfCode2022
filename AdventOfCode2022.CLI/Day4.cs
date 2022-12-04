using AdventOfCode.Puzzles.Day_4;

namespace AdventOfCode2022.CLI;

public class Day4
{
    public static void Print()
    {
        Console.WriteLine("----- Day 4 -----");
        Console.WriteLine("Example 1:");
        var sectionAssignments = Assignments.GiveAssignmentsFromFile(@".\day 4\input\example.txt");
        int noOfFullyContainedAssignments = Assignments.CountFullyContainedAssignments(sectionAssignments);
        Console.WriteLine($"Number of fully contained assignments: {noOfFullyContainedAssignments}");
        
        Console.WriteLine();
        Console.WriteLine("Example 2:");
        int noOfOverlappingAssignments = Assignments.CountOverlappingAssignments(sectionAssignments);
        Console.WriteLine($"Number of overlapping assignments: {noOfOverlappingAssignments}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 1:");
        sectionAssignments = Assignments.GiveAssignmentsFromFile(@".\day 4\input\puzzle.txt");
        noOfFullyContainedAssignments = Assignments.CountFullyContainedAssignments(sectionAssignments);
        Console.WriteLine($"Number of fully contained assignments: {noOfFullyContainedAssignments}");

        Console.WriteLine();
        Console.WriteLine("Puzzle 2:");
        noOfOverlappingAssignments = Assignments.CountOverlappingAssignments(sectionAssignments);
        Console.WriteLine($"Number of overlapping assignments: {noOfOverlappingAssignments}");
    }

}