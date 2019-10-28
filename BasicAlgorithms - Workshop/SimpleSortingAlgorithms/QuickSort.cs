using System;
using System.Collections.Generic;

namespace SimpleSortingAlgorithms
{
    public static class QuickSort
    {
        public static void Sort<T>(ref T[] array) where T : IComparable<T>
        {
            if (array.Length <= 1)
            {
                return;
            }

            int initialIndex = 0;
            int pivotIndex = initialIndex + ((array.Length - 1 - initialIndex) / 2);
            T pivotElement = array[pivotIndex];

            Remove(ref array, pivotIndex);

            List<T> less = new List<T>();
            List<T> greater = new List<T>();

            foreach (T element in array)
            {
                if (element.CompareTo(pivotElement) == 0 ||
                    element.CompareTo(pivotElement) == -1)
                {
                    less.Add(element);
                }
                else
                {
                    greater.Add(element);
                }
            }

            T[] lessArr = less.ToArray();
            T[] greaterArr = greater.ToArray();
            Sort(ref lessArr);
            Sort(ref greaterArr);
            array = Merge(lessArr, pivotElement, greaterArr);
        }

        private static T[] Merge<T>(T[] less, T pivotElement, T[] greater) where T : IComparable<T>
        {
            T[] merged = new T[less.Length + greater.Length + 1];

            Array.Copy(less, 0, merged, 0, less.Length);
            merged[less.Length] = pivotElement;
            Array.Copy(greater, 0, merged, less.Length + 1, greater.Length);

            return merged;
        }

        private static void Remove<T>(ref T[] array, int pivotIndex) where T : IComparable<T>
        {
            T[] newArr = new T[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (i == pivotIndex)
                {
                    j--;
                    continue;
                }

                newArr[j] = array[i];
            }

            array = newArr;
        }
    }
}
