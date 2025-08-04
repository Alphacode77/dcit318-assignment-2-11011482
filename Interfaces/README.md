# Interface Demonstration

This C# console application demonstrates the concept of interfaces using a simple example with movable objects.

## Project Structure

- **IMovable** (Interface): Defines a contract for objects that can move
- **Car** (Class): Implements IMovable interface and prints "Car is moving"
- **Bicycle** (Class): Implements IMovable interface and prints "Bicycle is moving"

## Key Concepts Demonstrated

### 1. Interface Definition

- Interfaces define a contract that classes must implement
- They provide a way to achieve multiple inheritance-like behavior
- Interfaces can contain method signatures and properties

### 2. Interface Implementation

- Classes implement the interface contract
- Implementation is enforced at compile time
- Provides a way to group objects by capability rather than inheritance

### 3. Polymorphism with Interfaces

- Objects can be treated based on their interface type
- Different objects implementing the same interface can be used interchangeably
- Enables loose coupling and flexibility

## How to Run

1. Navigate to the project directory:

   ```
   cd Interfaces
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
Interface Demonstration

Interface Implementation
Calling Move() method on Car:
Car is moving

Calling Move() method on Bicycle:
Bicycle is moving

Polymorphism with Interface
Movable object 1:
Car is moving

Movable object 2:
Bicycle is moving

Options:
1. Run again
2. Exit
Enter your choice (1 or 2):
```

## Code Features

- **Simple Interface**: IMovable interface with just one method
- **Multiple Implementations**: Both Car and Bicycle implement the same interface
- **Interface Polymorphism**: Objects are grouped by interface type
- **Contract Enforcement**: Compiler ensures all interface methods are implemented
- **Interactive Menu**: User-friendly interface for running demonstrations multiple times
- **Clean Output**: Simplified and focused demonstration of interface concepts
