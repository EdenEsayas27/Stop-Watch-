public class StopWatchService
{
    // Delegate declaration: Defines the signature for methods to be invoked by events
    public delegate void StopWatchServiceEvent();

    // Event declarations: These events are triggered for start, stop, and reset actions
    public event StopWatchServiceEvent? OnStart;  // Event to start the stopwatch
    public event StopWatchServiceEvent? OnStopped;  // Event to stop the stopwatch
    public event StopWatchServiceEvent? OnReset;  // Event to reset the stopwatch

    // Method to start the stopwatch by invoking the OnStart event
    public void StartWatch()
    {
        // Invoke OnStart event if there are any subscribers
        OnStart?.Invoke();  // The "?" ensures it only invokes if the event has subscribers
    }

    // Method to stop the stopwatch by invoking the OnStopped event
    public void StoppedWatch()
    {
        // Invoke OnStopped event if there are any subscribers
        OnStopped?.Invoke();  // The "?" ensures it only invokes if the event has subscribers
    }

    // Method to reset the stopwatch by invoking the OnReset event
    public void RestartWatch()
    {
        // Invoke OnReset event if there are any subscribers
        OnReset?.Invoke();  // The "?" ensures it only invokes if the event has subscribers
    }
}
