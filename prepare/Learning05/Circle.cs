public class Circle : Shape
{
    // Attributes
    private double _radius;
    // Behaviors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}