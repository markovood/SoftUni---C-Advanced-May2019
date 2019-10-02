using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStructures
{
    /// <summary>
    /// Represents an Array that can store integer numbers and dynamically resize or shrink itself
    /// </summary>
    public class MyList
    {
        private int capacity;
        private int[] innerArray;

        /// <summary>
        /// Creates a new instance of MyList class using the default capacity
        /// </summary>
        public MyList()
        {
            this.capacity = 2;
            this.innerArray = new int[this.capacity];
        }

        /// <summary>
        /// Creates a new instance of MyList class using the specified capacity
        /// </summary>
        /// <param name="capacity">The initial max number of elements in the collection</param>
        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.innerArray = new int[this.capacity];
        }

        /// <summary>
        /// Gets the count of elements in the collection
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Provides access to an element's value by specifying a zero-based index
        /// </summary>
        /// <param name="index">The zero-based index of the element to be accessed</param>
        /// <returns>The value of the element with the specified index</returns>
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count - 1)
                {
                    return this.innerArray[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (index >= 0 && index < this.Count - 1)
                {
                    this.innerArray[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Adds the given element to the end of the list
        /// </summary>
        /// <param name="element">The integer to add</param>
        public void Add(int element)
        {
            EnsureCapacity();
            this.innerArray[this.Count] = element;
            this.Count++;
        }

        /// <summary>
        /// Removes the element at the given index
        /// </summary>
        /// <param name="index">The index of the element to be removed</param>
        /// <returns>Returns the removed element value 
        /// or throws an exception if the index is not valid</returns>
        public int RemoveAt(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                int element = this.innerArray[index];
                Shift(index);
                this.Count--;
                if (this.capacity / 2 > this.Count)
                {
                    Shrink();
                }

                return element;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Checks if the list contains the given element
        /// </summary>
        /// <param name="element">The element which existence is to be confirmed</param>
        /// <returns>True if the element exists in the list
        /// or False or if it doesn't</returns>
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.innerArray[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Swaps the elements at the given indexes
        /// </summary>
        /// <param name="firstIndex">The index of the element that will be swapped</param>
        /// <param name="secondIndex">The index where the first element is going to be placed</param>
        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < this.Count)
            {
                if (secondIndex >= 0 && secondIndex < this.Count)
                {
                    int temp = this.innerArray[firstIndex];
                    this.innerArray[firstIndex] = this.innerArray[secondIndex];
                    this.innerArray[secondIndex] = temp;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("secondIndex");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("firstIndex");
            }
        }

        private void EnsureCapacity()
        {
            if (this.capacity == this.Count)
            {
                Resize();
            }
        }

        private void Resize()
        {
            // increase the internal collection's length twice
            this.capacity *= 2;
            int[] newArray = new int[this.capacity];
            this.innerArray.CopyTo(newArray, 0);
            this.innerArray = newArray;
        }

        private void Shrink()
        {
            // decrease the internal collection's length twice
            this.capacity /= 2;
            int[] newArray = new int[this.capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.innerArray[i];
            }

            this.innerArray = newArray;
        }

        private void Shift(int index)
        {
            // rearrange the internal collection's elements after removing one
            for (int i = index; i < this.Count - 1; i++)
            {
                innerArray[i] = innerArray[i + 1];
            }

            this.innerArray[this.Count - 1] = 0;
        }

        /// <summary>
        /// Gets the space separated representation of the collection
        /// </summary>
        /// <returns>All elements of the collection separated by a single space on a single line</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.innerArray[i] + " ");
            }

            return result.ToString().TrimEnd();
        }
    }
}
