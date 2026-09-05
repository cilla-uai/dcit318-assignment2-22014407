using System;

// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
}

// Circle class
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class
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

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter circle radius: ");
        if (!double.TryParse(Console.ReadLine(), out double radius) || radius < 0)
        {
            Console.WriteLine("Invalid radius.");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter rectangle width: ");
        if (!double.TryParse(Console.ReadLine(), out double width) || width < 0)
        {
            Console.WriteLine("Invalid width.");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter rectangle height: ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height < 0)
        {
            Console.WriteLine("Invalid height.");
            Console.ReadKey();
            return;
        }

        Circle circle = new Circle(radius);
        Rectangle rectangle = new Rectangle(width, height);

        Console.WriteLine($"\nCircle area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

        Console.ReadKey();
    }
}