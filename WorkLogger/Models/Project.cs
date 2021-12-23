namespace WorkLogger.Models;

public class Project
{
    private TimeUnitOfWork _current = new TimeUnitOfWork();

    /// <summary>
    /// New work project
    /// </summary>
    /// <param name="projectName"></param>
    /// <param name="company"></param>
    protected Project(string projectName, string company)
    {
        Name = projectName;
        Company = company;
        UnitOfWorks = new List<TimeUnitOfWork>();
    }

    /// <summary>
    /// Importing project
    /// </summary>
    /// <param name="unitOfWorks"></param>
    /// <param name="projectName"></param>
    /// <param name="company"></param>
    protected Project(List<TimeUnitOfWork> unitOfWorks, string projectName, string company)
    {
        UnitOfWorks = unitOfWorks;
        Name = projectName;
        Company = company;
    }

    protected TimeSpan Time
    {
        get
        {
            TimeSpan time = TimeSpan.Zero;
            UnitOfWorks.ForEach(t => time += t.GetEnd() - t.GetStart());
            return time;
        }
    }

    private List<TimeUnitOfWork> UnitOfWorks { get; set; }
    protected string Name { get; set; }
    protected string Company { get; set; }

    protected void Start()
    {
        _current = new TimeUnitOfWork();
        _current.Start();
    }

    protected void End(string message)
    {
        _current.End();
        _current.SetMessage(message);
        AddUnitOfWork(_current);
        _current = new TimeUnitOfWork();
    }

    private void AddUnitOfWork(TimeUnitOfWork unitOfWork)
    {
        UnitOfWorks.Add(unitOfWork);
    }

    public override string ToString()
    {
        return
            $"Company: {Company}; Project: {Name}; Time Worked: {Time}";
    }
}