namespace AdventOfCode.Puzzles.Day_3;

public class RucksacksInventoryList
{
    public List<Rucksack> FillRucksacks(string fileName)
    {
        var rucksacks = new List<Rucksack>();

        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();

                    rucksacks.Add(new Rucksack
                    {
                        Compartments = new List<Compartment>
                        {
                            new Compartment
                            {
                                Items = line[..(line.Length / 2)].ToCharArray()
                            },
                            new Compartment
                            {
                                Items = line[(line.Length / 2)..].ToCharArray()
                            }
                        }
                    });
                }
            }
        }

        return rucksacks;
    }
}