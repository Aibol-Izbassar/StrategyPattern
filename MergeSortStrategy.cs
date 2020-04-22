using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MergeSortStrategy : ISort
    {
        public void MySort(int[] arr)
        {
                int mid = arr.Length / 2;
                int[] leftArray = new int[mid];
                int[] rightArray = new int[arr.Length - mid];

                for (int z = 0; z < mid; z++)
                {
                    leftArray[z] = arr[z];

                }
                for (int z = mid; z < arr.Length; z++)
                {
                    rightArray[z - mid] = arr[z];
                }
                if (rightArray.Length > 1)
                    MySort(rightArray);
                if (leftArray.Length > 1)
                    MySort(leftArray);

                int i = 0;
                int j = 0;
                int k = 0;

                while (i < leftArray.Length && j < rightArray.Length)
                {
                    if (leftArray[i] < rightArray[j])
                    {
                        arr[k] = leftArray[i];
                        k++;
                        i++;
                    }
                    else
                    {
                        arr[k] = rightArray[j];
                        k++;
                        j++;
                    }
                }
                while (i < leftArray.Length)
                {
                    arr[k++] = leftArray[i++];
                }
                while (j < rightArray.Length)
                {
                    arr[k++] = rightArray[j++];
                }

        }
        
    }
}
