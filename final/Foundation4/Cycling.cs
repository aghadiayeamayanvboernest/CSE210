public class Cycling : Activity
{
    public double SpeedMph { get; private set; }

    public Cycling(DateTime date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        SpeedMph = speedMph;
    }

    public override double GetDistance()
    {
        return (SpeedMph * DurationMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return SpeedMph;
    }

    public override double GetPace()
    {
        return 60 / SpeedMph;
    }
}
