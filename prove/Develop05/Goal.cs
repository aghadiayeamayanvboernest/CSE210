public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string Name => _shortName;
    public string Description => _description;
    public int Points => _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public int points => _points;
    public string ShortName => _shortName;
    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}
