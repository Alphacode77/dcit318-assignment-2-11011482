using System;

namespace AbstractDemo
{
    // Abstract base class for shapes
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double CalculateArea();
        
        // Abstract method for calculating perimeter
        public abstract double CalculatePerimeter();
        
        // Virtual method with default implementation
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape Type: {GetType().Name}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
        
        // Abstract property
        public abstract string ShapeName { get; }
    }

    // Concrete class implementing the abstract Shape
    public class Circle : Shape
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        
        public override string ShapeName => "Circle";
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"{ShapeName}");
            Console.WriteLine($"Radius: {radius}");
            base.DisplayInfo();
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
        
        public override double CalculateArea()
        {
            return length * width;
        }
        
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
        
        public override string ShapeName => "Rectangle";
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"{ShapeName}");
            Console.WriteLine($"Length: {length}, Width: {width}");
            base.DisplayInfo();
        }
    }

    // Another concrete class
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        
        public override double CalculateArea()
        {
            // Using Heron's formula
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        
        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
        
        public override string ShapeName => "Triangle";
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"{ShapeName}");
            Console.WriteLine($"Sides: {sideA}, {sideB}, {sideC}");
            base.DisplayInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;
            
            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Abstract Classes and Methods Demonstration");
                Console.WriteLine();

                // Create instances of different shapes
                Circle circle = new Circle(5.0);
                Rectangle rectangle = new Rectangle(4.0, 6.0);
                Triangle triangle = new Triangle(3.0, 4.0, 5.0);

                // Demonstrate abstract class usage
                Console.WriteLine("Creating different shapes and calculating their properties:");
                Console.WriteLine();

                // Display information for each shape
                circle.DisplayInfo();
                Console.WriteLine();

                rectangle.DisplayInfo();
                Console.WriteLine();

                triangle.DisplayInfo();
                Console.WriteLine();

                // Demonstrate polymorphism with abstract base class
                Console.WriteLine("Polymorphism with Abstract Base Class");
                Shape[] shapes = { circle, rectangle, triangle };
                
                for (int i = 0; i < shapes.Length; i++)
                {
                    Console.WriteLine($"Shape {i + 1}: {shapes[i].ShapeName}");
                    Console.WriteLine($"Area: {shapes[i].CalculateArea():F2}");
                    Console.WriteLine($"Perimeter: {shapes[i].CalculatePerimeter():F2}");
                    Console.WriteLine();
                }

                // Demonstrate that you cannot instantiate an abstract class
                Console.WriteLine("Note: You cannot create an instance of the abstract Shape class.");
                Console.WriteLine("All shapes must be concrete implementations.");
                Console.WriteLine();

                Console.WriteLine("Options:");
                Console.WriteLine("1. Run again");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice (1 or 2): ");
                
                string choice = Console.ReadLine();
                
                if (choice == "2" || choice.ToLower() == "exit")
                {
                    continueRunning = false;
                    Console.WriteLine("Enjoy your day!");
                }
                else if (choice != "1" && choice.ToLower() != "run")
                {
                    Console.WriteLine("Invalid choice. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
} 