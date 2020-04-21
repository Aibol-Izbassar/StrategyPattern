using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class QuickSortStrategy : ISort
    {
        public void MySort()
        {
            //написать код сортировки
            Console.WriteLine("I am QUICK sort");
        }
    }
}
