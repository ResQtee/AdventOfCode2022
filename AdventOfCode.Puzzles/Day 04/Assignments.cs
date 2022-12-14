namespace AdventOfCode.Puzzles.Day_04;

public class Assignments
{
    public static List<(SectionAssignment firstAssignment, SectionAssignment secondAssignment)> GiveAssignmentsFromFile(string fileName)
    {
        var assignments = new List<(SectionAssignment, SectionAssignment)>();

        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();

                    var elfAssignments = line.Split(',');
                    assignments.Add((ParseAssignment(elfAssignments[0]), ParseAssignment(elfAssignments[1])));
                }
            }
        }

        return assignments;
    }

    public static int CountFullyContainedAssignments(List<(SectionAssignment firstAssignment, SectionAssignment secondAssignment)> assignments)
    {
        return assignments.Count(assignment => assignment.firstAssignment.Encapsulates(assignment.secondAssignment) 
                                               || assignment.firstAssignment.IsEncapsulated(assignment.secondAssignment));
    }

    public static int CountOverlappingAssignments(List<(SectionAssignment firstAssignment, SectionAssignment secondAssignment)> assignments)
    {
        return assignments.Count(assignment => assignment.firstAssignment.IsOverlapping(assignment.secondAssignment));
    }

    private static SectionAssignment ParseAssignment(string assignment)
    {
        var min = int.Parse(assignment.Substring(0, assignment.IndexOf('-')));
        var max = int.Parse(assignment.Substring(assignment.IndexOf('-') + 1));

        return new SectionAssignment { Min = min, Max = max };
    }
}