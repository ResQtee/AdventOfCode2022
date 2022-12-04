namespace AdventOfCode.Puzzles.Day_4;

public class SectionAssignment
{
    public int Min { get; set; }
    public int Max { get; set; }

    public bool Encapsulates(SectionAssignment other)
    {
        return Min <= other.Min && Max >= other.Max;
    }

    public bool IsEncapsulated(SectionAssignment other)
    {
        return other.Min <= Min && other.Max >= Max;
    }
}

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

    public static int CountFullyContainedAssignment(List<(SectionAssignment firstAssignment, SectionAssignment secondAssignment)> assignments)
    {
        return assignments.Count(assignment => assignment.firstAssignment.Encapsulates(assignment.secondAssignment) 
                                                                        || assignment.firstAssignment.IsEncapsulated(assignment.secondAssignment));
    }

    private static SectionAssignment ParseAssignment(string assignment)
    {
        var min = int.Parse(assignment.Substring(0, assignment.IndexOf('-')));
        var max = int.Parse(assignment.Substring(assignment.IndexOf('-') + 1));

        return new SectionAssignment { Min = min, Max = max };
    }
}