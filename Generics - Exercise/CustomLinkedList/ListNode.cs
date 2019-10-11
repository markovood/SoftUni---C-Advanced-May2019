using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public sealed class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public ListNode<T> Previous { get; set; }

        public ListNode<T> Next { get; set; }
    }
}
