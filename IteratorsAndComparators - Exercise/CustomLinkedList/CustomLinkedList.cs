using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private CustomLinkedListNode<T> head;
        private CustomLinkedListNode<T> tail;

        public int Count { get; private set; } = 0;

        /// <summary>
        /// Adds an element at the beginning of the collection
        /// </summary>
        /// <param name="element">The integer to be added to the start of the collection</param>
        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = new CustomLinkedListNode<T>(element);
                this.tail = this.head;
            }
            else
            {
                var newHead = new CustomLinkedListNode<T>(element);
                newHead.Next = this.head;
                this.head.Previous = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds an element at the end of the collection
        /// </summary>
        /// <param name="element">The integer to be added to the end of the collection</param>
        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.tail = new CustomLinkedListNode<T>(element);
                this.head = this.tail;
            }
            else
            {
                var newTail = new CustomLinkedListNode<T>(element);
                newTail.Previous = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        /// <summary>
        /// Removes the element at the beginning of the collection
        /// </summary>
        /// <returns>The removed element value</returns>
        public T RemoveFirst()
        {
            T removedValue;
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            else if (this.Count == 1)
            {
                removedValue = this.head.Value;
                this.head = null;
                this.tail = null;
            }
            else
            {
                removedValue = this.head.Value;
                this.head = this.head.Next;
                this.head.Previous = null;
            }

            this.Count--;
            return removedValue;
        }

        /// <summary>
        /// Removes the element at the end of the collection
        /// </summary>
        /// <returns>The removed element value</returns>
        public T RemoveLast()
        {
            T removedValue;
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            else if (this.Count == 1)
            {
                removedValue = this.tail.Value;
                this.tail = null;
                this.head = null;
            }
            else
            {
                removedValue = this.tail.Value;
                this.tail = this.tail.Previous;
                this.tail.Next = null;
            }

            this.Count--;
            return removedValue;
        }

        /// <summary>
        /// Goes through the collection and executes a given action
        /// </summary>
        /// <param name="action">The action to be performed over each element of the collection</param>
        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        /// <summary>
        /// Returns the collection as an array
        /// </summary>
        /// <returns>The collection as an array</returns>
        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            int index = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                result[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }

            return result;
        }

        /// <summary>
        /// Confirms if the passed element is contained in the collection
        /// </summary>
        /// <param name="element">The integer, which presence is to be confirmed</param>
        /// <returns>TRUE if the searched element exists or FALSE if it doesn't</returns>
        public bool Contains(T element)
        {
            if (this.Count == 0)
            {
                return false;
            }
            else
            {
                var currentElement = this.head;
                while (currentElement != null)
                {
                    if (currentElement.Value.Equals(element))
                    {
                        return true;
                    }

                    currentElement = currentElement.Next;
                }

                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var head = this.head;
            while (head != null)
            {
                yield return head.Value;
                head = head.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
