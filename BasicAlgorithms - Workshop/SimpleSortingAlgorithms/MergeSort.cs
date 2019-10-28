using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSortingAlgorithms
{
    public static class MergeSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] unsorted)
        {
            if (unsorted.Length <= 1)
            {
                return;
            }

            int midPoint = unsorted.Length / 2;

            T[] left = new T[midPoint];
            T[] right;

            if (unsorted.Length % 2 == 0)
            {
                right = new T[midPoint];
            }
            else
            {
                right = new T[midPoint + 1];
            }

            // fill-up the left and right parts
            for (int i = 0; i < midPoint; i++)
            {
                left[i] = unsorted[i];
            }

            for (int i = midPoint, x = 0; i < unsorted.Length; i++, x++)
            {
                right[x] = unsorted[i];
            }

            // recursively do that until unsorted is having just 1 element
            Sort(ref left);
            Sort(ref right);
            unsorted = Merge(left, right);
        }

        private static T[] Merge(T[] left, T[] right)
        {
            int resultLength = right.Length + left.Length;
            T[] result = new T[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft].CompareTo(right[indexRight]) == 0 ||
                        left[indexLeft].CompareTo(right[indexRight]) == -1)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array will be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }
    }
}
