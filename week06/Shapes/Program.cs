using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 = new Square("red", 7);
        Rectangle rectangle1 = new Rectangle("green", 6, 2);
        Circle circle1 = new Circle("purple", 4);

        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetType()} is {shape.GetArea()}");
        }

    }
}