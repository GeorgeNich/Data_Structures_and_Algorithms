# Doubly Linked List Implementation

Overview
This repository contains the implementation of a doubly linked list in C#. The doubly linked list includes basic operations such as adding elements, removing elements, finding elements, and more.

## Implementation Details

### [DoublyLinkedList Class](doublylinkedlists/DoublyLinkedList.cs)

The `DoublyLinkedList<T>` class represents a doubly linked list with nodes containing elements of type `T`. It includes methods for adding, removing, finding, and manipulating nodes within the list.

#### Public Methods and Properties

- `First`: Gets the first node in the doubly linked list.
- `Last`: Gets the last node in the doubly linked list.
- `After(INode<T> node)`: Gets the node after the specified node.
- `Before(INode<T> node)`: Gets the node before the specified node.
- `AddLast(T value)`: Adds a new node with the specified value at the end of the list.
- `AddFirst(T value)`: Adds a new node with the specified value at the beginning of the list.
- `AddBefore(INode<T> before, T value)`: Adds a new node with the specified value before the specified node.
- `AddAfter(INode<T> after, T value)`: Adds a new node with the specified value after the specified node.
- `Find(T value)`: Finds the first occurrence of a node with the specified value.
- `Remove(INode<T> node)`: Removes the specified node from the list.
- `RemoveFirst()`: Removes the first node from the list.
- `RemoveLast()`: Removes the last node from the list.
- `Clear()`: Removes all nodes from the list.

### [INode Interface](doublylinkedlists/INode.cs)

The `INode<T>` interface represents a node in the doubly linked list. It includes a property to get or set the value of the node.

### [Tester](doublylinkedlists/Tester.cs)

The `Tester` class serves as a testing module for the `DoublyLinkedList<T>` implementation. It contains a series of tests to validate the correctness of each operation in the `DoublyLinkedList<T>` class.

#### **Test Cases**

1. **Creating a New List:**
   - Creates a new instance of the `DoublyLinkedList<T>` class and verifies its initial state.

2. **Adding Elements to the List:**
   - Adds a sequence of integers to the list using the `AddLast(T value)` method.

3. **Removing Elements from the End:**
   - Removes the last four elements from the list using the `RemoveLast()` method.

4. **Adding Elements to the Beginning:**
   - Adds a sequence of integers to the beginning of the list using the `AddFirst(T value)` method.

5. **Removing Elements from the Beginning:**
   - Removes the first three elements from the list using the `RemoveFirst()` method.

6. **Finding Nodes by Value:**
   - Searches for nodes with specific values in the list using the `Find(T value)` method.

7. **Adding Nodes Before and After:**
   - Adds nodes with new values before and after an existing node in the list using the `AddBefore(INode<T> before, T value)` and `AddAfter(INode<T> after, T value)` methods.

8. **Removing Nodes:**
   - Removes specific nodes from the list using the `Remove(INode<T> node)` method.

9. **Clearing the List:**
   - Clears all nodes from the list using the `Clear()` method.

10. **Handling Edge Cases:**
    - Tests edge cases, such as attempting to remove nodes from an empty list and clearing an already empty list.

#### **Usage**

1. Download the source code and open it in Microsoft Visual Studio.
2. Compile and run the `Tester` class to execute the defined test cases.

#### **Notes**

- The `Tester` class provides a comprehensive set of tests to ensure the robustness of the `DoublyLinkedList<T>` implementation.

![Example](Doublylinkedlistscompletedsuccessfulexample.png)

Refer to the image above for an example of the doubly linked list's correct state after running the provided tests.

