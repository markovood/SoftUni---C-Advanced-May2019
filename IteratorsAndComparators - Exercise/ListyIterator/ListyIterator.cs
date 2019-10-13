using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex;
        private readonly List<T> collection;

        public ListyIterator(params T[] collection)
        {
            this.currentIndex = 0;
            this.collection = new List<T>(collection);
        }

        /// <summary>
        /// Moves an internal index position to the next index in the list.
        /// </summary>
        /// <returns>Returns true, if it had successfully moved the index 
        /// and false if there is no next index.</returns>
        public bool Move()
        {
            if (this.HasNext())
            {
                currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method returns true, if there is a next index and false,
        /// if the index is already at the last element of the collection.
        /// </summary>
        /// <returns>True, if there is a next index, and False, if it's the last index of the collection</returns>
        public bool HasNext()
        {
            if (this.currentIndex < this.collection.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Print the element at the current internal index.
        /// </summary>
        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.collection[currentIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
