using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DynamicArray 
    {
        int count = 0;
        ISort sort;
        int[] array = new int[100];
        public DynamicArray(ISort sort)
        {
            this.sort = sort;
        }
        public int this[int index] 
        { 
            get { return array[index]; } 
            set { array[index] = value; } 
        }
      
        public void Add(int num)
        {
            if (array.Length<count)
            {
                Resize(5);
                array[count] = num;
                count++;
            }
            array[count] = num;
            count++;
        }

        public void Resize(int size)
        {
            int[] newArray = new int[array.Length+size];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public int GetLength { get { return array.Length; } set { } }

        public void Sort()
        {
            sort.MySort(array);
        }

        public bool TestSort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
