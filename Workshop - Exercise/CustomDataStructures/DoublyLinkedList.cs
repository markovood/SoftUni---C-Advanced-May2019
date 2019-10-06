using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode head;
        private DoublyLinkedListNode tail;

        public int Count { get; private set; } = 0;

        /// <summary>
        /// Adds an element at the beginning of the collection
        /// </summary>
        /// <param name="element">The integer to be added to the start of the collection</param>
        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = new DoublyLinkedListNode(element);
                this.tail = this.head;
            }
            else
            {
                var newHead = new DoublyLinkedListNode(element);
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
        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.tail = new DoublyLinkedListNode(element);
                this.head = this.tail;
            }
            else
            {
                var newTail = new DoublyLinkedListNode(element);
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
        public int RemoveFirst()
        {
            int removedValue;
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
        public int RemoveLast()
        {
            int removedValue;
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
        public void ForEach(Action<int> action)
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
        public int[] ToArray()
        {
            int[] result = new int[this.Count];
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
        public bool Contains(int element)
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
                    if (currentElement.Value == element)
                    {
                        return true;
                    }

                    currentElement = currentElement.Next;
                }

                return false;
            }
        }
    }
}
