using System;

namespace heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heapUtil = new HeapUtil(new int[] {5,9,8,1,2,3,7,6});
            var heap = heapUtil.GetHeap();

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }


            //Console.ReadKey();
        }
    }
}
