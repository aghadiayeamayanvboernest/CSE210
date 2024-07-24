public class Running : Activity
{
    public double DistanceMiles { get; private set; }

    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return DistanceMiles;
    }

    public override double GetSpeed()
    {
        return (DistanceMiles / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / DistanceMiles;
    }
}
