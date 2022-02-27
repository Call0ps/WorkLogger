namespace WorkLogger.Core.Interfaces;

public interface IProject
{
    string Name { get; set; }
    string Company { get; set; }
    string Description { get; set; }
    int Budget { get; set; }
    bool IsActive { get; set; }
}