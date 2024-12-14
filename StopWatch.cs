
public class StopWatch
{
    private int TimeElapsed = 0;
    private bool IsRunning = false;

    public void Start(bool isRunning, string buttonType)
    {
        if (isRunning)
        {
            Console.WriteLine("Stopwatch already started.");
        }
        else
        {
            IsRunning = true;
            while (IsRunning)
            {
                Tick();
            }
        }
    }

    public void Stop(bool isRunning, string buttonType)
    {
        if (!isRunning)
        {
            Console.WriteLine("Stopwatch already stopped.");
        }
        else
        {
            IsRunning = false;
            Console.WriteLine($"Stopwatch stopped at {TimeElapsed} seconds.");
        }
    }

    public void Reset(bool isRunning, string buttonType)
    {
        TimeElapsed = 0;
        IsRunning = false;
        Console.WriteLine("Stopwatch reset.");
    }

    public void Tick()
    {
        TimeElapsed++;
        Console.WriteLine($"Time: {TimeElapsed} seconds");
        Thread.Sleep(1000); // Simulate 1 second interval
    }
}
