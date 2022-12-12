namespace AdventOfCode.Puzzles.Day_10;

public class CRT
{
    // Width = 40
    // Height = 6

    private readonly ClockCircuit clock;
    private readonly CPU cpu;

    private (int horizontalPixels, int verticalPixels) resolution = new(40, 6);
    private int horizontalPixel = 0;

    public CRT(ClockCircuit clock, CPU cpu)
    {
        this.clock = clock;
        this.cpu = cpu;
        
        clock.NewCycle += ClockOnNewCycle;
    }

    private void ClockOnNewCycle(object? sender, CycleThresholdReachedEventArgs e)
    {
        var registerX = cpu.RegisterX;

        if(horizontalPixel >= registerX-1 && horizontalPixel <= registerX+1)
        {
            DrawLightPixel();
        }
        else
        {
            DrawDarkPixel();
        }

        if (horizontalPixel == resolution.horizontalPixels-1)
        {
            Console.WriteLine();
            horizontalPixel = 0;
        }
        else
        {
            horizontalPixel++;
        }
    }

    private void DrawLightPixel()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("#");
        Console.ResetColor();
    }

    private void DrawDarkPixel()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(".");
        Console.ResetColor();
    }
}