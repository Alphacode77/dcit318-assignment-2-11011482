# DCIT318 Assignment 2 - Object-Oriented Programming Concepts

This repository contains comprehensive demonstrations of key Object-Oriented Programming concepts in C#. Each folder contains a separate project showcasing different OOP principles with interactive examples and detailed documentation.

## Project Structure

### [Abstract Classes and Methods](./AbstractClassesandMethods/)

**Demonstrates:** Abstract classes, abstract methods, and inheritance hierarchy

- **Shape** (Abstract Base Class): Defines abstract method `GetArea()`
- **Circle** (Concrete Class): Implements area calculation for circles
- **Rectangle** (Concrete Class): Implements area calculation for rectangles

**Key Features:**

- Abstract method implementation
- Mathematical calculations using real formulas
- Clean separation between abstract and concrete classes

**[View Documentation](./AbstractClassesandMethods/README.md)** | **[View Code](./AbstractClassesandMethods/Program.cs)**

---

### [Inheritance and Method Overriding](./InheritanceandMethodOverriding/)

**Demonstrates:** Class inheritance, virtual methods, method overriding, and polymorphism

- **Animal** (Base Class): Contains virtual `MakeSound()` method
- **Dog** (Derived Class): Overrides `MakeSound()` to print "Bark"
- **Cat** (Derived Class): Overrides `MakeSound()` to print "Meow"

**Key Features:**

- Virtual method implementation
- Method overriding with `override` keyword
- Polymorphic behavior demonstration
- Base class inheritance

**[View Documentation](./InheritanceandMethodOverriding/README.md)** | **[View Code](./InheritanceandMethodOverriding/Program.cs)**

---

### [Interfaces](./Interfaces/)

**Demonstrates:** Interface implementation, contract-based programming, and polymorphism

- **IMovable** (Interface): Defines contract for movable objects
- **Car** (Class): Implements `IMovable` and prints "Car is moving"
- **Bicycle** (Class): Implements `IMovable` and prints "Bicycle is moving"

**Key Features:**

- Interface contract implementation
- Multiple classes implementing the same interface
- Polymorphism through interface types
- Clean interface design

**[View Documentation](./Interfaces/README.md)** | **[💻 View Code](./Interfaces/Program.cs)**

---

## Quick Start

### Prerequisites

- .NET 8.0 SDK or later
- Any C# IDE (Visual Studio, VS Code, Rider, etc.)

### Running the Demonstrations

Each project can be run independently. Navigate to any project folder and run:

```bash
# Navigate to a project
cd AbstractClassesandMethods
# or
cd InheritanceandMethodOverriding
# or
cd Interfaces

# Build and run
dotnet build
dotnet run
```

##  Learning Objectives

This assignment covers the following OOP concepts:

### 1. **Abstract Classes**

- Understanding abstract class definition
- Implementing abstract methods
- Creating inheritance hierarchies
- Enforcing contracts through abstract classes

### 2. **Inheritance**

- Base class and derived class relationships
- Accessing inherited members
- Understanding inheritance chains
- Code reuse through inheritance

### 3. **Method Overriding**

- Virtual method declaration
- Override keyword usage
- Polymorphic behavior
- Runtime method resolution

### 4. **Interfaces**

- Interface contract definition
- Interface implementation
- Multiple interface implementation
- Interface-based polymorphism

### 5. **Polymorphism**

- Same interface, different implementations
- Runtime type determination
- Flexible object handling
- Code extensibility

## Technical Features

- **Interactive Menus**: Most demonstrations include interactive menu systems
- **Clear Output**: Well-formatted console output for easy understanding
- **Real Examples**: Practical implementations using geometric shapes and animals
- **Comprehensive Documentation**: Each project includes detailed README files
- **Modular Design**: Each concept is demonstrated in a separate, focused project

## Expected Learning Outcomes

After completing this assignment, students should be able to:

1. **Design and implement abstract classes** with appropriate abstract methods
2. **Create inheritance hierarchies** with proper base and derived class relationships
3. **Implement method overriding** using virtual and override keywords
4. **Define and implement interfaces** to create contract-based programming
5. **Understand polymorphism** and its practical applications
6. **Apply OOP principles** to solve real-world programming problems

## Code Quality Standards

- **Clean Code**: Well-structured, readable, and maintainable code
- **Proper Documentation**: Comprehensive comments and documentation
- **Error Handling**: Robust error handling where appropriate
- **Best Practices**: Following C# coding conventions and OOP principles
- **Modularity**: Each concept demonstrated in focused, independent projects

## Contributing

This is an academic assignment. For questions or clarifications about the implementations, please refer to the individual project documentation or contact the course instructor.
