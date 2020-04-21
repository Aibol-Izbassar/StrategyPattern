using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray dyn2 =  new DynamicArray(new MergeSortStrategy());
            dyn2.Sort();
            DynamicArray dyn = new DynamicArray(new QuickSortStrategy());
            dyn.Sort();
        }
    }
}
