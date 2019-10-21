using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    public class Socks
    {
        public static void Main()
        {
            int[] left = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] right = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> pairs = new Queue<int>();

            Stack<int> leftSocks = new Stack<int>(left);
            Queue<int> rightSocks = new Queue<int>(right);
            while (leftSocks.Count != 0 && rightSocks.Count != 0)
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    int pair = rightSock + leftSock;
                    pairs.Enqueue(pair);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (rightSock > leftSock)
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    leftSocks.Pop();
                    leftSock++;
                    leftSocks.Push(leftSock);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(' ', pairs));
        }
    }
}
