# Animal Inheritance and Method Overriding Demo

This C# console application demonstrates the concepts of inheritance and method overriding using a simple animal hierarchy.

## Project Structure

- **Animal** (Base Class): Contains a virtual `MakeSound()` method that prints "Some generic sound"
- **Dog** (Derived Class): Inherits from Animal and overrides `MakeSound()` to print "Bark"
- **Cat** (Derived Class): Inherits from Animal and overrides `MakeSound()` to print "Meow"

## Key Concepts Demonstrated

### 1. Inheritance

- `Dog` and `Cat` classes inherit from the `Animal` base class using the `: Animal` syntax
- This allows derived classes to access public members of the base class

### 2. Method Overriding

- The base class `Animal` has a `virtual` method `MakeSound()`
- Derived classes use the `override` keyword to provide their own implementation
- This enables polymorphic behavior

### 3. Polymorphism

- The program demonstrates polymorphism by storing different derived class instances in an array of the base class type
- When calling `MakeSound()` on each element, the appropriate derived class method is called

## How to Run

1. Navigate to the project directory:

   ```
   cd InheritanceandMethodOverriding/AnimalInheritance
   ```

2. Build the project:

   ```
   dotnet build
   ```

3. Run the application:

   ```
   dotnet run
   ```

## Expected Output

```
Animal Inheritance and Method Overriding Demo

Animal makes sound:
Some generic sound

Dog makes sound:
Bark

Cat makes sound:
Meow

Demonstrating polymorphism:
Animal 1 makes sound: Some generic sound
Animal 2 makes sound: Bark
Animal 3 makes sound: Meow

Press any key to exit...
```

## Code Features

- **Virtual Method**: The base class method is marked as `virtual` to allow overriding
- **Override Keyword**: Derived classes use `override` to provide custom implementations
- **Polymorphism**: The same method call produces different results based on the actual object type
- **Clean Output**: The program provides clear, formatted output showing each animal's sound
