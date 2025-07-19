using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test individual shapes first
            Square square = new Square("Red", 4);
            Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

            Rectangle rectangle = new Rectangle("Blue", 5, 3);
            Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

            Circle circle = new Circle("Green", 3);
            Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

            Console.WriteLine();

            // Create a list of shapes - this demonstrates polymorphism
            List<Shape> shapes = new List<Shape>();

            // Add different types of shapes to the same list
            shapes.Add(new Square("Yellow", 6));
            shapes.Add(new Rectangle("Purple", 8, 4));
            shapes.Add(new Circle("Orange", 5));

            // Iterate through the list and display each shape's info
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
            }
        }
    }
}