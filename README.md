# NullReferenceException in C# String Conversion from Integer

This repository demonstrates a subtle NullReferenceException that can occur when converting an integer to a string in C#.  The exception arises when the integer variable holds a value that, under certain circumstances, is interpreted as null in the conversion process.  Specifically, we'll examine the case of using `ToString()` on a numerical variable which might contain unexpected null values, which does not automatically handle null values and throws an exception.

## The Bug

The `Bug.cs` file contains a C# class that attempts to convert an integer property to a string.  If the integer property has the value 0, a NullReferenceException is thrown because the type conversion implicitly handles 0 as a null value.

## The Solution

The `BugSolution.cs` file demonstrates a solution to this problem. It includes explicit null checks and alternative approaches to safely convert integers to strings, preventing the exception.

## How to Reproduce

1. Clone the repository.
2. Open `Bug.cs` in a C# IDE.
3. Run the `MyMethod()` method within `ExampleClass` with the initial value of `MyProperty` set to 0.
4. Observe the NullReferenceException.
5. Then, modify the code with the solution from `BugSolution.cs` to see how it avoids the exception.
