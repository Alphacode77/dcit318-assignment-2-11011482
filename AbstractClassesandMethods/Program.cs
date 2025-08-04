using System;

namespace AbstractDemo
{
    // Abstract base class for shapes
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double GetArea();
    }

    // Concrete class implementing the abstract Shape
    public class Circle : Shape
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Another concrete class
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        
        public override double GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes and Methods Demonstration");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine("Circle Area: " + circle.GetArea().ToString("F2"));
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea().ToString("F2"));
        }
    }
} 