using System;

namespace InterfaceDemo
{
    // Interface defining a contract for objects that can move
    public interface IMovable
    {
        void Move();
    }

    // Class implementing the IMovable interface
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class implementing the IMovable interface
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
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
                Console.WriteLine("Interface Demonstration");
                Console.WriteLine();

                // Create instances of Car and Bicycle
                Car car = new Car();
                Bicycle bicycle = new Bicycle();

                // Demonstrate interface usage
                Console.WriteLine("Interface Implementation");
                Console.WriteLine("Calling Move() method on Car:");
                car.Move();
                Console.WriteLine();

                Console.WriteLine("Calling Move() method on Bicycle:");
                bicycle.Move();
                Console.WriteLine();

                // Demonstrate polymorphism with interface
                Console.WriteLine("Polymorphism with Interface");
                IMovable[] movables = { car, bicycle };
                
                for (int i = 0; i < movables.Length; i++)
                {
                    Console.WriteLine($"Movable object {i + 1}:");
                    movables[i].Move();
                    Console.WriteLine();
                }

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