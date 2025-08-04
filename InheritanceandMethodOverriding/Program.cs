using System;

namespace AnimalInheritance
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog that overrides MakeSound method
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat that overrides MakeSound method
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
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
                Console.WriteLine("Animal Inheritance and Method Overriding");
                Console.WriteLine();

                // Create instances of Animal, Dog, and Cat
                Animal animal = new Animal();
                Dog dog = new Dog();
                Cat cat = new Cat();

                // Call MakeSound() method on each instance
                Console.WriteLine("Animal makes sound:");
                animal.MakeSound();
                Console.WriteLine();

                Console.WriteLine("Dog makes sound:");
                dog.MakeSound();
                Console.WriteLine();

                Console.WriteLine("Cat makes sound:");
                cat.MakeSound();
                Console.WriteLine();

                // Demonstrate polymorphism by using base class reference
                Console.WriteLine("Demonstrating polymorphism:");
                Animal[] animals = { animal, dog, cat };
                
                for (int i = 0; i < animals.Length; i++)
                {
                    Console.Write($"Animal {i + 1} makes sound: ");
                    animals[i].MakeSound();
                }

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
