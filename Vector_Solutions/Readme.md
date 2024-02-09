# Data Structures and Algorithms

This repository contains solutions for the Vector Practical Task in the SIT221 Data Structures and Algorithms course (Trimester 1, 2021) at Deakin University.

## Vector Practical Task Overview

The Vector Practical Task focuses on implementing a generic vector data structure in C#. The provided solution includes a `Vector<T>` class with various methods for vector manipulation, such as adding, removing, inserting, and checking for elements.

## Directory Structure

- **1.1PVector**
  - [1.1PVector.sln](./1.1PVector/1.1PVector.sln): Visual Studio solution file.
  - [Readme.md](./1.1PVector/Readme.md): Instructions and details about the vector implementation.

### Source Code

- [program.cs](./1.1PVector/program.cs): Contains a testing program for the `Vector<T>` class.
- [vector.cs](./1.1PVector/vector.cs): Implementation of the generic `Vector<T>` class.

## Usage

To run the provided test program:

1. Open the solution file `1.1PVector.sln` in Visual Studio.
2. Build and run the solution.

The program will execute a series of tests on the `Vector<T>` class, checking various operations like adding, removing, inserting, and more.

## Test Summary

After running the program, a summary will be displayed, indicating the success or failure of each test. Ensure that all tests pass successfully.

## Vector<T> Class

The `Vector<T>` class provides the following methods:

- `Add(T element)`: Adds a new element to the vector.
- `IndexOf(T element)`: Searches for the index of the specified element.
- `Insert(int index, T element)`: Inserts an element at the specified index.
- `Clear()`: Clears all elements from the vector.
- `Contains(T element)`: Checks if the vector contains a specific element.
- `Remove(T element)`: Removes the first occurrence of a specific element.
- `RemoveAt(int index)`: Removes the element at the specified index.
- `ToString()`: Returns a string representation of the vector.

Feel free to explore the source code for more details on each method.

## Author

- [Your Name]

---

**Note:** This repository is part of the academic coursework. Use the code responsibly and avoid academic misconduct.


