using System;

namespace CustomStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new MyList(9);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int removed3 = list.RemoveAt(2);
            int removed4 = list.RemoveAt(2);
            bool contains3 = list.Contains(3);
            bool contains5 = list.Contains(5);
            list.Swap(0, 2);
            list.Swap(2, 1);
            Console.WriteLine(list);
        }
    }
}
