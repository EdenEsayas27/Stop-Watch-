public class StopWatch
{
    private int TimeElapsed = 0; // Time in seconds
    private bool IsRunning = false; 
    private Timer? timer;// variable  declaration for timer
    private int TimeDisplayLine = 0; // Line to display the time

    public void Start()
    {
        if (IsRunning)
        {
            Console.WriteLine("Stopwatch is already running.");
            return;
        }

        Console.WriteLine("Stopwatch started.");
        IsRunning = true;

        // Ensure the time display starts below the current cursor
        TimeDisplayLine = Console.CursorTop;
        timer = new Timer(Tick, null, 0, 1000); // Start timer, tick every 1000ms (1 second)
    }

    public void Stop()
    {
        if (!IsRunning)
        {
            Console.WriteLine("Stopwatch is already stopped.");
            return;
        }

        IsRunning = false;
        timer?.Dispose();  // Stop the timer
        Console.WriteLine("\nStopwatch stopped at");
        DisplayTime();//to display the time it stopped 
    }

    public void Reset()
    {
        TimeElapsed = 0;
        IsRunning = false;
        Console.WriteLine("\nStopwatch reset.");
        timer?.Dispose();  // Stop the timer
        DisplayTime(); // Display time after reset
    }

    private void Tick(object? state)
    {
        if (IsRunning)
        {
            TimeElapsed++;
            DisplayTime(); // Display time in HH:mm:ss format
        }
    }
    private void DisplayTime()
{
    // Calculate hours, minutes, and seconds
    int hours = TimeElapsed / 3600;
    int minutes = (TimeElapsed % 3600) / 60;
    int seconds = TimeElapsed % 60;

    // Display the updated time on the same line, with padding for clean formatting
    Console.Write($"\rTime: {hours:D2}:{minutes:D2}:{seconds:D2}\t");
}


    
}
