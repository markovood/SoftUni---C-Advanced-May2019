using System;

namespace Recursion
{
    public static class RecursiveArraySum
    {
        public static int Sum(int[] arr, int startIndex = 0)
        {
            int currentElement = arr[startIndex];
            if (startIndex == arr.Length - 1)
            {
                return arr[startIndex];
            }
            
            int currentSum = Sum(arr, ++startIndex);
            return currentElement + currentSum;
        }
    }
}
