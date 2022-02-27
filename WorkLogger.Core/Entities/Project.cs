using WorkLogger.Core.Interfaces;

namespace WorkLogger.Core.Entities;

public class Project : IBaseEntity, IDates, IProject
{
    // Run-time
    public List<WorkPost> WorkPosts { get; set; } = new();
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Name { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
    public int Budget { get; set; }
    public bool IsActive { get; set; } = true;
}