# Race Condition in C# Property Access

This repository demonstrates a race condition that can occur in C# when accessing a property or method before an object is fully initialized. In multithreaded environments, this can lead to unexpected behavior or crashes.

## The Bug

The `bug.cs` file contains a simple class with a property and a method.  If multiple threads attempt to access `MyProperty` before `MyMethod` completes initialization, a race condition can occur.

## The Solution

The `bugSolution.cs` file shows how to mitigate this race condition using appropriate synchronization mechanisms, such as locks.