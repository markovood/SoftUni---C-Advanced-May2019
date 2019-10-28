using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithms
{
    public static class BinarySearch
    {
        public static int IndexOf<T>(T[] sortedArr, T valueToSearch) where T : IComparable<T>
        {
            int startIndex = 0;
            int endIndex = sortedArr.Length - 1;

            while (startIndex <= endIndex)
            {
                int midIndex = startIndex + (endIndex - startIndex) / 2;
                T midElement = sortedArr[midIndex];
                int result = midElement.CompareTo(valueToSearch);
                if (result == 0)
                {
                    return midIndex;
                }
                else if (result < 0)
                {
                    // move the lower bound to the index after the midIndex, so that search to the right
                    startIndex = midIndex + 1;
                }
                else
                {
                    // move the upper bound to the index before the midIndex, so that search to the left
                    endIndex = midIndex - 1;
                }
            }

            // element is not found
            return -1;
        }
    }
}
