using System;
using System.Collections.Generic;

namespace heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heapUtil = new HeapUtil<int>(new int[] {5,9,8,1,2,3,7,6});
            heapUtil.Add(10);

            Console.WriteLine("Heap");
            var heap = heapUtil.GetHeap();
            Print(heap);
            Console.WriteLine("Sorted");

            var sorted = heapUtil.Sort();
            Print(sorted);






            


            //Console.ReadKey();
        }

        static void Print(IList<int> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
