using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DynamicArray 
    {
        ISort sort;
        public DynamicArray(ISort sort)
        {
            this.sort = sort;
        }
        public void Sort()
        {
            sort.MySort();
        }
    }
}
