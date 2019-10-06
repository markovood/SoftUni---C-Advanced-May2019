using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new DoublyLinkedList();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            list.AddLast(11);
            list.AddLast(22);
            list.AddLast(33);

            // list.ForEach(Console.WriteLine);

            int removed3 = list.RemoveFirst();
            Console.WriteLine(string.Join(' ', list.ToArray()));
            Console.WriteLine(list.Count);
            Console.WriteLine(removed3);

            int removed33 = list.RemoveLast();
            Console.WriteLine(string.Join(' ', list.ToArray()));
            Console.WriteLine(list.Count);
            Console.WriteLine(removed33);

            Console.WriteLine(list.Contains(11));
            Console.WriteLine(list.Contains(111));

            var otherList = new DoublyLinkedList();
            Console.WriteLine(otherList.Contains(11));
        }
    }
}
