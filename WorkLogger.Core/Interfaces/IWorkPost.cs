namespace WorkLogger.Core.Interfaces;

public interface IWorkPost
{
    string Comment { get; set; }
    TimeSpan Duration { get; }
    Guid ProjectId { get; set; }
}