namespace AdventOfCode.Puzzles.Day_11
{
    public class InputReader
    {
        public MonkeyTroop Read(string fileName, IMonkeyInspection inspection)
        {
            var lines = File.ReadAllLines(fileName);
            ulong commonFactor = 1;

            // count number of monkeys
            var noOfMonkeys = lines.Count(line => line.StartsWith("Monkey", StringComparison.OrdinalIgnoreCase));
            var monkeys = new Monkey[noOfMonkeys];

            int currentLineNumber = 0;

            for (int i = 0; i < monkeys.Length; i++)
            {
                // currentLineNumber + 0 = monkey id
                var id = i;

                // currentLineNumber + 1 = worryLevels
                var worryLevels = ParseWorryLevels(lines[currentLineNumber + 1]);

                // currentLineNumber + 2 = operation
                var worryLevelOperator = ParseWorryLevelOperation(lines[currentLineNumber + 2]);

                // currentLineNumber + 3 = division
                var divisionNumber = ParseLastNumber(lines[currentLineNumber + 3]);

                // currentLineNumber + 4 = true monkey id
                // currentLineNumber + 5 = false monkey id
                // currentLineNumber + 6 = empty

                monkeys[i] = new Monkey(worryLevels, inspection, worryLevelOperator, divisionNumber);
                monkeys[i].Id = id;
                commonFactor *= monkeys[i].DivisionValue;

                currentLineNumber += 7;
            }

            // back to the beginning
            currentLineNumber = 0;

            for (int i = 0; i < monkeys.Length; i++)
            {
                // currentLineNumber + 0 = monkey id
                // currentLineNumber + 1 = worryLevels
                // currentLineNumber + 2 = operation
                // currentLineNumber + 3 = division
                // currentLineNumber + 4 = true monkey id
                var monkey1Id = ParseLastNumber(lines[currentLineNumber + 4]);
                monkeys[i].TrueMonkey = monkeys[monkey1Id];

                // currentLineNumber + 5 = false monkey id
                var monkey2Id = ParseLastNumber(lines[currentLineNumber + 5]);
                monkeys[i].FalseMonkey = monkeys[monkey2Id];
                monkeys[i].CommonFactor = commonFactor;

                currentLineNumber += 7;
            }

            return new MonkeyTroop(monkeys);
        }

        private ulong ParseLastNumber(string line)
        {
            var sanitizedLine = line.Trim();
            var numberString = sanitizedLine[(sanitizedLine.LastIndexOf(" ")+1)..];
            return ulong.Parse(numberString);
        }

        private List<ulong> ParseWorryLevels(string line)
        {
            var itemsString = line[(line.IndexOf(':') + 1)..];
            return itemsString.Split(',').Select(ulong.Parse).ToList();
        }

        private WorryLevelOperation ParseWorryLevelOperation(string line)
        {
            return new WorryLevelOperation(line[(line.IndexOf("=", StringComparison.Ordinal) + 1)..]);
        }
    }
}