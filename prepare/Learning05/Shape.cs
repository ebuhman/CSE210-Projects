using System.Drawing;

public abstract class Shape
{
    // Attributes
    protected string _color;
    // Setters
    public Shape()
    {
        _color = "White";
    }
    public Shape(string color)
    {
        _color = color;
    }
    // Getters
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}