
class Program
{
    static void Main()
    {
        StopWatch stopWatch = new StopWatch();
        var stopWatchService = new StopWatchService();
        
        // Subscribing to the events
        stopWatchService.OnStart += stopWatch.Start;
        stopWatchService.OnStopped += stopWatch.Stop;
        stopWatchService.OnReset += stopWatch.Reset;

        Console.WriteLine("Press 'S' to start the stopwatch.");
        Console.WriteLine("Press 'T' to stop it.");
        Console.WriteLine("Press 'R' to reset it.");
        Console.WriteLine("Press 'Q' to quit.");

        // Infinite loop for user input
        while (true)
        {
            string choice = Console.ReadLine().ToUpper();  // Convert input to uppercase

            switch (choice)
            {
                case "S":
                    stopWatchService.StartWatch(false, "Start");
                    break;
                case "T":
                    stopWatchService.StoppedWatch(true, "Stop");
                    break;
                case "R":
                    stopWatchService.RestartWatch(true, "Reset");
                    break;
                case "Q":
                    Console.WriteLine("Exiting program.");
                    return;  // Exit the program
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
