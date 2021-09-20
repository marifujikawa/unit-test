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
        public static List<int> InsertSort(List<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int j = i;
                while (j-1 >= 0 &&  arr[j-1] < arr[i] )
                {
                    j--;
                }

                int aux = arr[i + 1];
                for (int k = i; k > j; k--)
                {
                    arr[k] = arr[k - 1];
                }

                arr[j] = aux;


            }
            return arr;
        }
        public static List<int> SelectSort(List<int> arr)
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
