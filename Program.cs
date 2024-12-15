class Program
{
    static void Main()
    {
        // Create an instance of StopWatch to manage stopwatch functionality
        StopWatch stopWatch = new StopWatch();
        
        // Create an instance of StopWatchService to handle events and interactions
        var stopWatchService = new StopWatchService();

        // Subscribe to events, linking each event to its corresponding method in StopWatch
        stopWatchService.OnStart += stopWatch.Start;   // Event to start the stopwatch
        stopWatchService.OnStopped += stopWatch.Stop;   // Event to stop the stopwatch
        stopWatchService.OnReset += stopWatch.Reset;   // Event to reset the stopwatch

        // Display available commands for the user to interact with the stopwatch
        Console.WriteLine("*********** STOP WATCH ***************");
        Console.WriteLine("Press 'S' to start the stopwatch.");
        Console.WriteLine("Press 'T' to stop it.");
        Console.WriteLine("Press 'R' to reset it.");
        Console.WriteLine("Press 'Q' to quit.");

        // Infinite loop to keep the program running, awaiting user input
        while (true)
        {
            string input = Console.ReadLine() ?? "";    // Read the user's input, ensuring it's never null
            string choice = input.ToUpper();            // Convert the input to uppercase to handle both cases

            // Execute actions based on the user's choice
            switch (choice)
            {
                case "S":
                    stopWatchService.StartWatch();    // Start the stopwatch when 'S' is pressed
                    break;
                case "T":
                    stopWatchService.StoppedWatch();  // Stop the stopwatch when 'T' is pressed
                    break;
                case "R":
                    stopWatchService.RestartWatch();  // Reset the stopwatch when 'R' is pressed
                    break;
                case "Q":
                    Console.WriteLine("Exiting program.");  // Print exit message when 'Q' is pressed
                    return;  // Exit the program
                default:
                    Console.WriteLine("Invalid option, try again.");  // Print an error message for invalid input
                    break;
            }
        }
    }
}
