using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>
        {
           new Square("Red", 4),
           new Rectangle("Blue", 5, 3),
           new Circle("Green", 2.5)
        };
        foreach (Shape shape in shapes)
     
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}