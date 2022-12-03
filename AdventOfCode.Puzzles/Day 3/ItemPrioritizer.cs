namespace AdventOfCode.Puzzles.Day_3;

// ReSharper disable once IdentifierTypo
public class ItemPrioritizer
{
    public int Prioritize(char itemType)
    {
        // Ascii value minus constant will get a score.
        if (char.IsUpper(itemType))
        {
            return itemType - 38; // to get to value 27.
        }

        return itemType - 96; // to get to value 1.
    }

    public int Prioritize(IEnumerable<char> items)
    {
        return items.Sum(Prioritize);
    }
}