using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class insSortStrategy : ISort
    {
        public void MySort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i;
                while (j >= 0 && array[j] > array[j + 1])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
        }
    }
}
