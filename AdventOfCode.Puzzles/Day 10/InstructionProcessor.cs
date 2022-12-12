namespace AdventOfCode.Puzzles.Day_10
{
    public class InstructionProcessor
    {
        public void Execute(string fileName, CPU cpu)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();

                        if (line.StartsWith("noop",StringComparison.OrdinalIgnoreCase))
                        {
                            cpu.NoOp();
                        }

                        else if (line.StartsWith("AddX", StringComparison.OrdinalIgnoreCase))
                        {
                            cpu.AddX(int.Parse(line.Split(" ")[1]));
                        }
                    }
                }
            }
        }
    }

    public class CycleThresholdReachedEventArgs : EventArgs
    {
        public int Cycles { get; set; }
    }

    public class ClockCircuit
    {
        public event EventHandler<CycleThresholdReachedEventArgs>? CycleThresholdReached;
        
        public int CycleId { get; private set; } = 0;

        private readonly List<int> cycleEventTriggers = new() { 20, 60, 100, 140, 180, 220 };

        public void Cycle()
        {
            CycleId++;

            if (cycleEventTriggers.Contains(CycleId))
            {
                var args = new CycleThresholdReachedEventArgs
                {
                    Cycles = CycleId
                };
                OnCycleThresholdReached(args);
            }
        }

        private void OnCycleThresholdReached(CycleThresholdReachedEventArgs e)
        {
            CycleThresholdReached?.Invoke(this, e);
        }
    }

    public class CPU
    {
        private readonly ClockCircuit clock;

        public int RegisterX { get; private set; }

        public CPU(ClockCircuit clock)
        {
            this.clock = clock;
            RegisterX = 1;

            clock.CycleThresholdReached += OnClockOnCycleThresholdReached;
        }

        private void OnClockOnCycleThresholdReached(object? sender, CycleThresholdReachedEventArgs e)
        {
            Console.WriteLine($"C:{e.Cycles} | X:{RegisterX}");
        }

        // Instruction Set.

        public int AddX(int x)
        {
            //Console.WriteLine($"Add {x}");
            clock.Cycle();
            clock.Cycle();
            RegisterX += x;

            return RegisterX;
        }

        public void NoOp()
        {
            //Console.WriteLine($"Noop");
            clock.Cycle();
        }
    }
}