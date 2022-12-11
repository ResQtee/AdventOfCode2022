namespace AdventOfCode.Puzzles.Day_05;

public class CrateMover9000 : ICrateMover
{
    public Cargo MoveCrate(Cargo cargo, MoveCrateInstruction moveInstruction)
    {
        for (int i = 0; i < moveInstruction.NoOfCrates; i++)
        {
            var crate = cargo.CrateStacks[moveInstruction.FromStackIndex].Pop();
            cargo.CrateStacks[moveInstruction.ToStackIndex].Push(crate);
        }

        return cargo;
    }
}

public class CrateMover9001 : ICrateMover
{
    public Cargo MoveCrate(Cargo cargo, MoveCrateInstruction moveInstruction)
    {
        var crates = new List<char>();
        for (int i = 0; i < moveInstruction.NoOfCrates; i++)
        {
            crates.Add(cargo.CrateStacks[moveInstruction.FromStackIndex].Pop());
        }

        for (int i = crates.Count-1;i >= 0; i--)
        {
            cargo.CrateStacks[moveInstruction.ToStackIndex].Push(crates[i]);
        }

        return cargo;
    }
}

public interface ICrateMover
{
    Cargo MoveCrate(Cargo cargo, MoveCrateInstruction moveInstruction);
}