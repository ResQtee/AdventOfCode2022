namespace AdventOfCode.Puzzles.Day_11;

public class MonkeyTroop
{
    public MonkeyTroop(IEnumerable<Monkey> monkeys)
    {
        Troop = new List<Monkey>(monkeys);
        Console.WriteLine($"Troop:");
        PrintWorryLevels();
    }

    private List<Monkey> Troop { get; }

    public void Round()
    {
        foreach (var monkey in Troop)
        {
            monkey.ThrowAllOneAtATime();
        }
    }

    private readonly List<int> inspectionRounds = new() {1,20,1000,2000,3000,4000,5000,6000,7000,8000,9000,10000};

    public void Rounds(int rounds)
    {
        for (int i = 0; i < rounds; i++)
        {
            Round();
            
            if (inspectionRounds.Contains(i+1))
            {
                Console.WriteLine($"Round {i+1}");
                PrintInspectionLvl();
                Console.WriteLine();
            }
        }
    }

    public ulong TwoHighestInspections()
    {
        var x = Troop.OrderByDescending(m => m.TimesInspected).Take(2).ToList();
        return x[0].TimesInspected * x[1].TimesInspected;
    }

    public void PrintTroop()
    {
        foreach (var monkey in Troop)
        {
            Console.WriteLine(monkey.ToString());
        }
    }

    private void PrintWorryLevels()
    {
        for (int i = 0; i < Troop.Count; i++)
        {
            Console.WriteLine($"Monkey {i}: {string.Join(",", Troop[i].WorryLevels)}");
        }
    }

    private void PrintInspectionLvl()
    {
        for (int i = 0; i < Troop.Count; i++)
        {
            Console.WriteLine($"Monkey {i}: {Troop[i].TimesInspected}");
        }
    }
}