# Abstract Classes and Methods Demonstration

This C# console application demonstrates the concept of abstract classes and methods using a geometric shapes example with an interactive menu system.

## Project Structure

- **Shape** (Abstract Base Class): Contains abstract methods and properties that must be implemented
- **Circle** (Concrete Class): Implements the abstract Shape class
- **Rectangle** (Concrete Class): Implements the abstract Shape class
- **Triangle** (Concrete Class): Implements the abstract Shape class

## Key Concepts Demonstrated

### 1. Abstract Classes

- Abstract classes cannot be instantiated directly
- They serve as base classes for other classes
- Can contain both abstract and concrete members
- Provide a common interface for derived classes

### 2. Abstract Methods

- Methods declared with the `abstract` keyword
- Must be implemented by derived classes
- No implementation in the abstract class
- Enforce a contract for derived classes

### 3. Abstract Properties

- Properties that must be implemented by derived classes
- Provide a way to define common properties across related classes
- Can be read-only, write-only, or read-write

### 4. Virtual Methods

- Methods that can be overridden in derived classes
- Provide default implementation in the base class
- Derived classes can choose to override or use the default

## How to Run

1. Navigate to the project directory:

   ```
   cd "Abstract Classes and Methods"
   ```

2. Build the project:

   ```
   dotnet build
   ```

3. Run the application:

   ```
   dotnet run
   ```

## Interactive Features

The application now includes an interactive menu system that allows you to:

- Run the demonstration multiple times
- Exit the application cleanly
- View the demonstration with a clear, formatted output

## Expected Output

```
Abstract Classes and Methods Demonstration

Creating different shapes and calculating their properties:

=== Circle ===
Radius: 5
Shape Type: Circle
Area: 78.54
Perimeter: 31.42

Rectangle
Length: 4, Width: 6
Shape Type: Rectangle
Area: 24.00
Perimeter: 20.00

Triangle
Sides: 3, 4, 5
Shape Type: Triangle
Area: 6.00
Perimeter: 12.00

Polymorphism with Abstract Base Class
Shape 1: Circle
Area: 78.54
Perimeter: 31.42

Shape 2: Rectangle
Area: 24.00
Perimeter: 20.00

Shape 3: Triangle
Area: 6.00
Perimeter: 12.00

Note: You cannot create an instance of the abstract Shape class.
All shapes must be concrete implementations.

Options:
1. Run again
2. Exit
Enter your choice (1 or 2):
```

## Code Features

- **Abstract Methods**: `CalculateArea()` and `CalculatePerimeter()` must be implemented
- **Abstract Properties**: `ShapeName` property must be implemented
- **Virtual Methods**: `DisplayInfo()` can be overridden but has a default implementation
- **Polymorphism**: All shapes can be treated as Shape objects
- **Mathematical Calculations**: Real geometric formulas for area and perimeter
- **Clean Architecture**: Clear separation between abstract and concrete classes
- **Interactive Menu**: User-friendly interface for running demonstrations multiple times
- **Clear Console Output**: Formatted display of shape information and calculations

## Key Differences from Interfaces

- Abstract classes can have implementation details
- Abstract classes can have constructors
- Abstract classes can have access modifiers
- A class can inherit from only one abstract class (but multiple interfaces)
- Abstract classes can have fields and properties with implementation
