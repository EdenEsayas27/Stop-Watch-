
public class StopWatchService
{
    public delegate void StopWatchServiceEvent(bool IsRunning, string buttonType);
    public event StopWatchServiceEvent OnStart;
    public event StopWatchServiceEvent OnStopped;
    public event StopWatchServiceEvent OnReset;

    public void StartWatch(bool IsRunning, string buttonType)
    {
        OnStart?.Invoke(IsRunning, buttonType);
    }

    public void StoppedWatch(bool IsRunning, string buttonType)
    {
        OnStopped?.Invoke(IsRunning, buttonType);
    }

    public void RestartWatch(bool IsRunning, string buttonType)
    {
        OnReset?.Invoke(IsRunning, buttonType);
    }
}
