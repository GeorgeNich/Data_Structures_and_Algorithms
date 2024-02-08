using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1PVector
{
    public class Vector<T>
    {
        // This constant determines the default number of elements in a newly created vector.
        // It is also used to extended the capacity of the existing vector
        private const int DEFAULT_CAPACITY = 10;

        // This array represents the internal data structure wrapped by the vector class.
        // In fact, all the elements are to be stored in this private  array. 
        // You will just write extra functionality (methods) to make the work with the array more convenient for the user.
        private T[] data;

        // This property represents the number of elements in the vector
        public int Count { get; private set; } = 0;

        // This property represents the maximum number of elements (capacity) in the vector
        public int Capacity { get; private set; } = 0;

        // This is an overloaded constructor
        public Vector(int capacity)
        {
            data = new T[capacity];
        }

        // This is the implementation of the default constructor
        public Vector() : this(DEFAULT_CAPACITY) { }

        // An Indexer is a special type of property that allows a class or structure to be accessed the same way as array for its internal collection. 
        // For example, introducing the following indexer you may address an element of the vector as vector[i] or vector[0] or ...
        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                return data[index];
            }
            set
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                data[index] = value;
            }
        }

        // This private method allows extension of the existing capacity of the vector by another 'extraCapacity' elements.
        // The new capacity is equal to the existing one plus 'extraCapacity'.
        // It copies the elements of 'data' (the existing array) to 'newData' (the new array), and then makes data pointing to 'newData'.
        private void ExtendData(int extraCapacity)
        {
            T[] newData = new T[data.Length + extraCapacity];
            for (int i = 0; i < Count; i++) newData[i] = data[i];
            data = newData;
        }

        // This method adds a new element to the existing array.
        // If the internal array is out of capacity, its capacity is first extended to fit the new element.
        public void Add(T element)
        {
            if (Count == data.Length) ExtendData(DEFAULT_CAPACITY);
            data[Count++] = element;
        }

        // This method searches for the specified object and returns the zero‐based index of the first occurrence within the entire data structure.
        // This method performs a linear search; therefore, this method is an O(n) runtime complexity operation.
        // If occurrence is not found, then the method returns –1.
        // Note that Equals is the proper method to compare two objects for equality, you must not use operator '=' for this purpose.
        public int IndexOf(T element)
        {
            for (var i = 0; i < Count; i++)
            {
                if (data[i].Equals(element)) return i;
            }
            return -1;
        }

        // TODO:********************************************************************************************
        // TODO: Your task is to implement all the remaining methods.
        // Read the instruction carefully, study the code examples from above as they should help you to write the rest of the code.
        public void Insert(int index, T element)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException(); // if index is above count throw IndexOutOfRangeException()
            }

            if (Count == data.Length)
            {
                ExtendData(DEFAULT_CAPACITY); //if count is the same as data.length Extend data using default capacity constant
               
            }
            if (index == Count)
            {
                Add(element);   // if index is the same as count use the predefined add() function and pass in element adding it to the end of the vector array
                return;
            }
            if (index >= 0 && index < data.Length )
            {
                for (int i = Count; i > index; i--) // iterate through the array starting at the end working inwards
                {
                    
                    data[i] = data[i - 1]; // make the current index value the one before it moving it along
                              
                }
                
                data[index] = element; // when arriving at the desired index, insert the element
                
            }
            Count = Count + 1; //update the count with to include the newly added element 
        }

        public void Clear()
        {
            
            
            Count = 0; // set count to 0
            data = new T[DEFAULT_CAPACITY]; // overwrite the existing array to a new generic array using the default capacity constant




        }

        public bool Contains(T element)
        {


            if (IndexOf(element) != -1) // use indexof element to see in the vector contains the generic element
            {                            // if it does it will return i not -1 so therefore return true
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Remove(T element)
        {
            int index = IndexOf(element);
            if(index != -1) // find the index of the element using the index of check
            {   
                RemoveAt(index); // remove the index of the passed through element
                return true; // return true since it returns a bool to the calling functions
            } 

                return false;
            
        }

        public void RemoveAt(int index)
        {
            int value;
            if (index < 0 || index > Count - 1) // this is a check to see if the index is valid
            {
                throw new IndexOutOfRangeException(); // if it fits this ^ criteria throw this exception
            }

            for (value = index; value < Count ; value++) // for loop to iteration upwards from the removed element at desired index 
            {
                data[value] = data[value + 1]; // overwrites the current element of the index with the element one index infront


            }

            data[Count] = default(T);   // since we removed an element, the element at count should be set to default
            Count = Count - 1; // Count-- to account for the removed element
            
          
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("[" , Count); // implement string builder

            for (int i = 0; i < Count; i++)  // iterate through to count-1
            {
                builder.Append(data[i]);    //append index value to the builder string

                if(i != Count-1)            // i is less than index append a comma
                {
                    builder.Append(','); // seperate with comma
                }
                
            }
            builder.Append(']'); // close it
            return builder.ToString(); // return it


            //string Emptystring = "";
            //foreach (var item in data)      // for each loop to add the item to the empty string Emptystring
            //{
            //    Emptystring += item;              OLD CODE
            //}
            //return Emptystring;

        }
              
            
    }
}