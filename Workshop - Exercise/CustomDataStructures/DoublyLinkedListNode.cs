using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public sealed class DoublyLinkedListNode
    {
        public DoublyLinkedListNode(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public DoublyLinkedListNode Previous { get; set; }

        public DoublyLinkedListNode Next { get; set; }
    }
}
