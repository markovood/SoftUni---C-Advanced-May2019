using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStructures
{
    /// <summary>
    /// Represents an Array that can store integer numbers, similar to the C# Stack but with custom functionality
    /// </summary>
    public class MyStack
    {
        private int capacity = 4;
        private int[] array;

        public MyStack()
        {
            this.array = new int[this.capacity];
        }

        public MyStack(int capacity)
        {
            this.capacity = capacity;
            this.array = new int[this.capacity];
        }

        public int Count { get; private set; } = 0;

        /// <summary>
        /// Adds an element to the end of the collection
        /// </summary>
        /// <param name="element">The element to be added to the end of collection</param>
        public void Push(int element)
        {
            // ensure capacity
            if (this.Count == this.capacity)
            {
                Grow();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        /// <summary>
        /// Removes the last element form the collection
        /// </summary>
        /// <returns>Returns the removed element</returns>
        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("MyStack is empty!");
            }

            int removed = this.array[this.Count - 1];
            this.array[this.Count - 1] = 0;// this line might be removed
            this.Count--;
            if (this.capacity / 2 > this.Count)
            {
                Shrink();
            }

            return removed;
        }

        /// <summary>
        /// Returns the last element from the collection, but it doesn't remove it
        /// </summary>
        /// <returns>The last element from the collection</returns>
        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("MyStack is empty!");
            }

            int lastElement = this.array[this.Count - 1];
            return lastElement;
        }

        /// <summary>
        /// This goes through every element from the collection and executes the given action
        /// </summary>
        /// <param name="action">The action delegate to be executed over each element</param>
        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.array[i]);
            }
        }

        private void Shrink()
        {
            // decrease the internal collection's length twice
            this.capacity /= 2;
            int[] newArray = new int[this.capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void Grow()
        {
            // increase the internal collection's length twice
            this.capacity *= 2;
            int[] newArray = new int[this.capacity];
            this.array.CopyTo(newArray, 0);
            this.array = newArray;
        }
    }
}
