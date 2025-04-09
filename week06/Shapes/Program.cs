using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.SetColor("Blue");
        square1.SetSide(5);
        square1.SetShapeType("Square");

        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetColor("Green");
        rectangle1.SetShapeType("Rectangle");
        rectangle1.SetSides(5,10);

        Circle circle1 = new Circle();
        circle1.SetColor("Yellow");
        circle1.SetRadius(20);
        circle1.SetShapeType("Circle");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetShapeType()} is {shape.GetColor()} and has an Area of {shape.GetArea()}");
        
        }
        

    }
}