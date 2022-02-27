using WorkLogger.Core.Interfaces;

namespace WorkLogger.Core.Entities;

public class WorkPost : IBaseEntity, IDates, IWorkPost
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Guid ProjectId { get; set; }
    public string Comment { get; set; }
    public TimeSpan Duration => End - Start;
}