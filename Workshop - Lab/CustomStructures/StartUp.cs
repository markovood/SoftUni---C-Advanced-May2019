using System;

namespace CustomStructures
{
    public class StartUp
    {
        public static void Main()
        {
            MyList list = new MyList(9);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int removed3 = list.RemoveAt(2);
            int removed4 = list.RemoveAt(2);
            // int exceptionExpected = list.RemoveAt(20);
            // int exceptionExpected = list.RemoveAt(-2);
            bool contains3 = list.Contains(3);
            bool contains5 = list.Contains(5);
            list.Swap(0, 2);
            list.Swap(2, 1);
            Console.WriteLine(list);

            MyStack stack = new MyStack(9);
            stack.Push(11);
            stack.Push(22);
            stack.Push(33);
            stack.ForEach(Console.WriteLine);
            int removed33 = stack.Pop();
            int removed22 = stack.Pop();
            int peeked = stack.Peek();
            int removed11 = stack.Pop();
            // int exceptionExpected = stack.Pop();
            // int exceptionExpected = stack.Peek();
        }
    }
}
