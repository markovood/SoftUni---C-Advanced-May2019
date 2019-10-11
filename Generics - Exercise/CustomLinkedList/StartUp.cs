using System;

namespace CustomLinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new CustomLinkedList<string>();

            list.AddFirst("1");
            list.AddFirst("2");
            list.AddFirst("3");

            list.AddLast("11");
            list.AddLast("22");
            list.AddLast("33");

            list.ForEach(Console.WriteLine);

            string removed3 = list.RemoveFirst();
            Console.WriteLine(string.Join(' ', list.ToArray()));
            Console.WriteLine(list.Count);
            Console.WriteLine(removed3);

            string removed33 = list.RemoveLast();
            Console.WriteLine(string.Join(' ', list.ToArray()));
            Console.WriteLine(list.Count);
            Console.WriteLine(removed33);

            Console.WriteLine(list.Contains("11"));
            Console.WriteLine(list.Contains("111"));

            var otherList = new CustomLinkedList<string>();
            Console.WriteLine(otherList.Contains("11"));
        }
    }
}
