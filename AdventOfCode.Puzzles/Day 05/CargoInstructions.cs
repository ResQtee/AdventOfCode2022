namespace AdventOfCode.Puzzles.Day_05
{
    public class CargoInstructions
    {
        public static (Cargo cargo, List<MoveCrateInstruction> instructions) LoadCargoInstructions(string fileName)
        {
            var moveCommands = new List<MoveCrateInstruction>();
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

        public static Cargo UnloadCargo(Cargo cargo, List<MoveCrateInstruction> unloadInstructions, ICrateMover crateMover)
        {
            foreach (var moveCrateCommand in unloadInstructions)
            {
                crateMover.MoveCrate(cargo, moveCrateCommand);
            }

            return cargo;
        }

        private static Cargo ParseCargoLines(List<string> cargoLines)
        {
            var cargo = new Cargo();
            
            // reverse through the cargo lines
            for (int cargoLineIndex = cargoLines.Count-1; cargoLineIndex >= 0; cargoLineIndex--)
            {
                int stackIndex = 0;
                int cursorIndex = 1;

                while (cursorIndex < cargoLines[cargoLineIndex].Length-1)
                {
                    // First time create a stack of crate(s).
                    if (cargoLineIndex == cargoLines.Count - 1)
                    {   
                        cargo.CrateStacks.Add(new Stack<char>());
                    }

                    char box = cargoLines[cargoLineIndex][cursorIndex];
                    if (box != ' ')
                    {
                        cargo.CrateStacks[stackIndex].Push(box);
                    }

                    stackIndex++;
                    cursorIndex+=4;
                }
            }

            return cargo;
        }

        private static MoveCrateInstruction ParseMoveCommand(string moveString)
        {
            // index: 0    1 2    3 4  5
            //        move 1 from 2 to 1
            var splitMoveString = moveString.Split(' ');
            
            return new MoveCrateInstruction
            {
                NoOfCrates = int.Parse(splitMoveString[1]),
                FromStackIndex = int.Parse(splitMoveString[3])-1,
                ToStackIndex = int.Parse(splitMoveString[5])-1
            };
        }
    }
}