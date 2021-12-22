using System.ComponentModel;

namespace WorkLogger.Models;

public class Work : Project
{
    /// <summary>
    /// New work project
    /// </summary>
    /// <param name="project"></param>
    /// <param name="budget"></param>
    /// <param name="company"></param>
    public Work(string project, int budget, string company) : base(project, company)
    {
        Budget = budget;
    }

    /// <summary>
    /// Importing project
    /// </summary>
    /// <param name="unitOfWorks"></param>
    /// <param name="project"></param>
    /// <param name="budget"></param>
    /// <param name="company"></param>
    public Work(List<TimeUnitOfWork> unitOfWorks, string project, int budget, string company) : base(unitOfWorks,
        project, company)
    {
        Budget = budget;
    }

    private int Budget { get; set; }

    public override string ToString()
    {
        return
            $"Company: {base.Company}; Project: {base.Name}; Time Worked: {base.Time}; Left of budget: {Budget - base.Time}";
    }

    public new void Start()
    {
        base.Start();
    }

    public new void End(string message)
    {
        base.End(message);
    }
}