public class Circle : Shape
{
    private double _redius;

    public Circle(string color, double redius) : base(color)
    {
        _redius = redius;
    }

    public override double GetArea()
    {
        return Math.PI * _redius * _redius;
    }
}