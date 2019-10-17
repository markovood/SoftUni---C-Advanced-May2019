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

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
