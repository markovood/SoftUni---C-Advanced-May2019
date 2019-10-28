using System;
using System.Linq;

namespace SearchingAlgorithms
{
    public class StartUp
    {
        public static void Main()
        {
            int[] someSortedArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(
                BinarySearch.IndexOf(
                    someSortedArr, int.Parse(
                        Console.ReadLine())));
        }
    }
}
