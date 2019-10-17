using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomLinkedListNode<T>
    {
        public CustomLinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public CustomLinkedListNode<T> Previous { get; set; }

        public CustomLinkedListNode<T> Next { get; set; }
    }
}
