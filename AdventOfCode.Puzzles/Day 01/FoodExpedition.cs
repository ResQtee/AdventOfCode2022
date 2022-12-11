using System.Collections.ObjectModel;

namespace AdventOfCode.Puzzles.Day_01;

public class FoodExpedition
{
    private readonly List<Elf> elves = new();

    public ReadOnlyCollection<Elf> Elves => elves.AsReadOnly();

    public void AddElfToExpedition(Elf elf)
    {
        elves.Add(elf);
    }

    public Elf? WhoHasTheHighestCalorieCount()
    {
        return elves.MaxBy(elf => elf.Calories.Total);
    }

    public ReadOnlyCollection<Elf> Top3HighestCalorieCountElves()
    {
        return elves.OrderByDescending(elf => elf.Calories.Total).Take(3).ToList().AsReadOnly();
    }

    public FoodExpedition CreateExpeditionFromFile(string fileName)
    {
        var elf = new Elf();
        AddElfToExpedition(elf);

        using (var fileStream = File.OpenRead(fileName))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                do
                {
                    string? line = streamReader.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {
                        elf = new Elf();
                        AddElfToExpedition(elf);
                    }
                    else
                    {
                        elf.AddCalories(int.Parse(line));
                    }

                } while (!streamReader.EndOfStream);
            }
        }
        return this;
    }
}