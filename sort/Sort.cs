using System;
using System.Collections.Generic;

namespace sort
{
    public class Sort
    {
        public static List<int> QuickSort(List<int> arr)
        {
            throw new NotImplementedException();
        }
        public static List<int> SelectSort(List<int> arr)
        {
            throw new NotImplementedException();
        }
        public static List<int> InsertSort(List<int> arr)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                int largestIndex = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[largestIndex])
                    {
                        largestIndex = j;
                    }
                }
                arr = SwitchPosition(arr, i, largestIndex);
            }
            return arr;
        }

        private static List<int> SwitchPosition(List<int> arr, int i, int largestIndex)
        {
            int aux = arr[i];
            arr[i] = arr[largestIndex];
            arr[largestIndex] = aux;
            return arr;
        }
    }
}
