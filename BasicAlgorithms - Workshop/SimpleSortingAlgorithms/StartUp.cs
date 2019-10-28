using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSortingAlgorithms
{
    public class StartUp
    {
        public static void Main()
        {
            int[] unsorted = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //MergeSort<int>.Sort(ref unsorted);
            //Console.WriteLine(string.Join(' ', unsorted));

            QuickSort.Sort(ref unsorted);
            Console.WriteLine(string.Join(' ', unsorted));
        }
    }
}
