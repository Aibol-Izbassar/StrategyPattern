using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MergeSortStrategy : ISort
    {
        public void MySort()
        {
            //написать код сортировки
            Console.WriteLine("I am MERGE sort");
        }
    }
}
