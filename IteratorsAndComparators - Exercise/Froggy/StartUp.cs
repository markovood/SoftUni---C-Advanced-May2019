using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            int[] stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);
            List<int> frogsPath = new List<int>();
            foreach (var stone in lake)
            {
                frogsPath.Add(stone);
            }

            Console.WriteLine(string.Join(", ", frogsPath));
        }
    }
}
