# Abstract Classes and Methods Demonstration

This C# console application demonstrates the concept of abstract classes and methods using a simple geometric shapes example.

## Project Structure

- **Shape** (Abstract Base Class): Contains abstract method GetArea() that must be implemented
- **Circle** (Concrete Class): Implements the abstract Shape class with area calculation
- **Rectangle** (Concrete Class): Implements the abstract Shape class with area calculation

## Key Concepts Demonstrated

### 1. Abstract Classes

- Abstract classes cannot be instantiated directly
- They serve as base classes for other classes
- Can contain abstract methods that must be implemented by derived classes
- Provide a common interface for derived classes

### 2. Abstract Methods

- Methods declared with the `abstract` keyword
- Must be implemented by derived classes
- No implementation in the abstract class
- Enforce a contract for derived classes

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

## Expected Output

```
Abstract Classes and Methods Demonstration

Circle Area: 78.54
Rectangle Area: 24.00
```

## Code Features

- **Abstract Method**: `GetArea()` must be implemented by derived classes
- **Simple Implementation**: Focuses on core abstract class concepts
- **Mathematical Calculations**: Real geometric formulas for area calculation
- **Clean Architecture**: Clear separation between abstract and concrete classes
