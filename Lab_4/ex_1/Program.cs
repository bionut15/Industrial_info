using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double GetArea()
    {
        return 0.5 * Base * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(10, 5);
        Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());

        Triangle triangle = new Triangle(6, 4);
        Console.WriteLine("Area of Triangle: " + triangle.GetArea());
    }
}
