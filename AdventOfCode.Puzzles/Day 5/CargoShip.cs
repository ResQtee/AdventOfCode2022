namespace AdventOfCode.Puzzles.Day_5
{
    public class CargoShip
    {
        public static (Cargo cargo, List<MoveCrateCommand> craneCommands) LoadCargo(string fileName)
        {
            var moveCommands = new List<MoveCrateCommand>();
            Cargo cargo;
            
            using (var fileStream = File.OpenRead(fileName))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    var cargoLines = new List<string>();
                    

                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();

                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }

                        // found crate
                        if (line.Contains('['))
                        {
                            cargoLines.Add(line);
                        }

                        if (line.StartsWith("move", StringComparison.OrdinalIgnoreCase))
                        {
                            moveCommands.Add(ParseMoveCommand(line));
                        }
                    }

                    cargo = ParseCargoLines(cargoLines);
                }
            }

            return (cargo, moveCommands);
        }

        public static Cargo UnloadCargo(Cargo cargo,List<MoveCrateCommand> moveCrateCommands)
        {
            foreach (var moveCrateCommand in moveCrateCommands)
            {
                
            }

            return cargo;
        }

        private static Cargo ParseCargoLines(List<string> cargoLines)
        {
            Cargo cargo = new Cargo();
            

            // reverse through the cargo lines
            for (int cargoLineIndex = cargoLines.Count-1; cargoLineIndex > 0; cargoLineIndex--)
            {
                // Nope!!
                // crates are split by a space....only on the first line.
                var splitCargoLine = cargoLines[cargoLineIndex].Split(' ');
                for (int stackIndex = 0; stackIndex < splitCargoLine.Length; stackIndex++)
                {
                    if (cargoLineIndex == cargoLines.Count-1)
                    {
                        cargo.CrateStacks.Add(new Stack<char>());
                    }

                    if (!string.IsNullOrWhiteSpace(splitCargoLine[stackIndex]))
                    {
                        // cargo is '[C]', so always second char(index 1);
                        cargo.CrateStacks[stackIndex].Push(splitCargoLine[stackIndex][1]);
                    }
                }
            }

            return cargo;
        }

        private static MoveCrateCommand ParseMoveCommand(string moveString)
        {
            // index: 0    1 2    3 4  5
            //        move 1 from 2 to 1
            var splitMoveString = moveString.Split(' ');
            
            return new MoveCrateCommand
            {
                NoOfCrates = int.Parse(splitMoveString[1]),
                FromStackIndex = int.Parse(splitMoveString[3])-1,
                ToStackIndex = int.Parse(splitMoveString[5])-1
            };
        }
    }

    public class MoveCrateCommand
    {
        public int NoOfCrates { get; set; }
        public int FromStackIndex { get; set; }
        public int ToStackIndex { get; set; }
    }

    public class Cargo
    {
        public List<Stack<char>> CrateStacks { get; set; } = new List<Stack<char>>();

        public void MoveCrates(MoveCrateCommand moveCommand)
        {
            for (int i = 0; i < moveCommand.NoOfCrates; i++)
            {
                var crate = CrateStacks[moveCommand.FromStackIndex].Pop();
                CrateStacks[moveCommand.ToStackIndex].Push(crate);
            }
        }
    }
}