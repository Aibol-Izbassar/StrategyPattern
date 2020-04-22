using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray dyn2 = new DynamicArray(new insSortStrategy());
            DynamicArray dyn1 = new DynamicArray(new MergeSortStrategy());
            
            Random r = new Random();

            for (int i = 0; i < dyn2.GetLength; i++)
            {
                dyn2[i] = r.Next(0, 100);
                dyn1[i] = r.Next(0, 100);
            }

            dyn1.Sort();
            dyn2.Sort();

            if (dyn1.TestSort())
            {
                Console.WriteLine("Sorted");
            }

            if (dyn2.TestSort())
            {
                Console.WriteLine("Sorted");
            }
            
        }
    }
}
