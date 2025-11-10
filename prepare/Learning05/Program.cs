using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square square = new Square("black", 2);
        _shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 8, 2);
        _shapes.Add(rectangle);

        Circle circle = new Circle("blue", 2.34);
        _shapes.Add(circle);

        foreach (Shape shape in _shapes)
        {
            double area = shape.GetArea();

            string color = shape.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}