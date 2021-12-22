namespace WorkLogger.Models;

public class Shift
{
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }
    private TimeSpan TimeWorked { get; set; }
    private string? Message { get; set; }

    public void Start()
    {
        StartTime = DateTime.UtcNow;
    }

    public void End()
    {
        EndTime = DateTime.UtcNow;
        SetTimeWorked();
    }

    public DateTime GetStart()
    {
        return StartTime;
    }

    public DateTime GetEnd()
    {
        return EndTime;
    }

    private void SetTimeWorked()
    {
        TimeWorked = EndTime - StartTime;
    }

    public void SetMessage(string message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return $"Start time: {StartTime}, End time: {EndTime}, Duration: {TimeWorked}\r\nMessage: {Message}";
    }
}