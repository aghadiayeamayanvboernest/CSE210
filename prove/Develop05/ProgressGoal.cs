public class ProgressGoal : Goal
{
    private int _currentProgress;
    private int _targetProgress;

    public ProgressGoal(string name, string description, int points, int targetProgress) : base(name, description, points)
    {
        _currentProgress = 0;
        _targetProgress = targetProgress;
    }

    public override void RecordEvent()
    {
        _currentProgress++;
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _targetProgress;
    }

    public override string GetDetailsString()
    {
        return $"[{(_currentProgress >= _targetProgress ? "X" : " ")}] {_shortName}: {_description} Progress: {_currentProgress}/{_targetProgress}";
    }

    public override string GetStringRepresentation()
    {
        return $"ProgressGoal|{_shortName}|{_description}|{_points}|{_currentProgress}|{_targetProgress}";
    }
}
