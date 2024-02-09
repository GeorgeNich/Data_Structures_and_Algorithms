#Basic Sorting Algorithms

Overview
This repository contains the implementation of sorting algorithms (Bubble Sort, Insertion Sort, and Selection Sort) in C# for the Vector class. The Vector class is an extension of the class implemented in Task 1.1P and includes an association relationship with sorting algorithms through the ISorter interface.

## Task Objective

The goal of this task is to implement and test three sorting algorithms for the Vector class, leveraging the ISorter interface with generics. The sorting algorithms are Bubble Sort, Insertion Sort, and Selection Sort.

## Implementation Details

### Vector Class

The Vector class represents a dynamic array with the ability to store elements of any type.
It includes methods for adding elements, accessing elements by index, and searching for elements.
The class implements the ISorter interface, allowing it to be associated with different sorting algorithms.

### Sorting Algorithms

- [BubbleSort](./BasicSorting_Solutions/BubbleSort.cs): Implementation of the Bubble Sort algorithm.
  - Method: Sort<K>(K[] sequence, IComparer<K> comparer)

- [InsertionSort](./BasicSorting_Solutions/InsertionSort.cs): Implementation of the Insertion Sort algorithm.
  - Method: Sort<K>(K[] sequence, IComparer<K> comparer)

- [SelectionSort](./BasicSorting_Solutions/SelectionSort.cs): Implementation of the Selection Sort algorithm.
  - Method: Sort<K>(K[] sequence, IComparer<K> comparer)

### ISorter Interface

The ISorter interface defines a generic method Sort<K> for sorting an array.
The interface includes support for a custom comparer to allow different sorting criteria.

## Usage

1. Download the source code and open it in Microsoft Visual Studio.
2. Compile and test the code.
3. Use the Tester class to validate the correctness of the implemented sorting algorithms.

![Vector Tests](BasicSortingtestscompletedresource.png)

The program will execute a series of tests on the `Vector<T>` class, checking various operations like adding, removing, inserting, and more.

## Test Summary

After running the program, a summary will be displayed, indicating the success or failure of each test. Ensure that all tests pass successfully.

## Testing

The Tester class provides a set of test cases to validate the correctness of each sorting algorithm. Ensure that the program prints "SUCCESS" for all tests before submission.

## Author

- George Nicholson

---

**Note:** This repository is part of the academic coursework. Use the code responsibly and avoid academic misconduct.
