namespace AdventOfCode.Puzzles.Day_03;

public class Rucksack
{
    public List<Compartment>? Compartments { get; set; }

    public IEnumerable<char> AllItems()
    {
        IEnumerable<char> items = new List<char>();
        if (Compartments == null)
        {
            return items;
        }

        return Compartments.Aggregate(items, (current, compartment) => current.Concat(compartment.Items));
    }

    public char FindOutOfPlaceItem()
    {
        return FindOutOfPlaceItem(Compartments).FirstOrDefault();
    }
    
    public IEnumerable<char> FindCommonItems(Rucksack[] rucksacks)
    {
        IEnumerable<char> commonItems = this.AllItems(); // not really common items at first, it makes it so we can intersect with this rucksack's items.
        foreach (var rucksack in rucksacks)
        {
            commonItems = commonItems.Intersect(rucksack.AllItems());
        }

        return commonItems;
    }

    private IEnumerable<char> FindOutOfPlaceItem(IReadOnlyList<Compartment>? compartments)
    {
        if (compartments == null)
        {
            return new List<char>();
        }

        var commonItems = compartments.First().Items;
        for (var index = 1; index < compartments.Count; index++)
        {
            commonItems = commonItems.Intersect(compartments[index].Items);
        }

        return commonItems;
    }
}