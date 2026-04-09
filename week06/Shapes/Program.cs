using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4);
        Rectangle rectangle = new Rectangle(4, 8);
        Circle circle = new Circle(3);


        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
    }
}