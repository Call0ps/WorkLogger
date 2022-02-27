using WorkLogger.Core.Entities;
using WorkLogger.Core.Interfaces;

namespace WorkLogger.Infrastructure.Handlers;

public class ProjectHandler : IBaseEntity
{
    public Project Project { get; set; }
    public TimeSpan ConsumedTime { get; set; }
    public TimeSpan TimeLeft { get; set; }
    public Guid Id { get; set; }
}