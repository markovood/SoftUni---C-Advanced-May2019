using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private int capacity = 4;
        private T[] array;

        public CustomStack()
        {
            this.array = new T[this.capacity];
        }

        public CustomStack(int capacity)
        {
            this.capacity = capacity;
            this.array = new T[this.capacity];
        }

        public int Count { get; private set; } = 0;

        /// <summary>
        /// Adds an element to the end of the collection
        /// </summary>
        /// <param name="element">The element to be added to the end of collection</param>
        public void Push(T element)
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
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            T removed = this.array[this.Count - 1];
            this.array[this.Count - 1] = default(T);
            this.Count--;
            if (this.capacity / 2 > this.Count)
            {
                Shrink();
            }

            return removed;
        }

        private void Shrink()
        {
            // decrease the internal collection's length twice
            this.capacity /= 2;
            T[] newArray = new T[this.capacity];
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
            T[] newArray = new T[this.capacity];
            this.array.CopyTo(newArray, 0);
            this.array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
