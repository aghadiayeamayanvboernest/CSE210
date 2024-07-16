public class NegativeGoal : Goal
{
    private int _penaltyPoints;

    public NegativeGoal(string name, string description, int points, int penaltyPoints) : base(name, description, points)
    {
        _penaltyPoints = penaltyPoints;
    }

    public int penaltyPoints => _penaltyPoints;

    public override void RecordEvent()
    {
        // Negative goals should subtract points
        Console.WriteLine($"Penalty incurred: {_penaltyPoints} points");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} Penalty: {_penaltyPoints} points";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{_shortName}|{_description}|{_points}|{_penaltyPoints}";
    }
}