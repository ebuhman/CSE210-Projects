public class Square : Shape
{
    // Attributes
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}