using System;
using System.Collections.Generic;
using System.Linq;

namespace heap
{
	public class HeapUtil
	{
		private List<int> heap;
		private int size;

		public HeapUtil(IEnumerable<int> arr)
		{
			heap = arr.ToList();
			size = heap.Count();
			buildHeap();
		}

		public List<int> GetHeap()
		{
			return heap;
		}

		private void buildHeap()
		{
			for (int i = (size-1)/2; i >= 0; i--)
			{
				maxHeapify(i);
			}
		}

		private int left(int n)
		{
			return 2*n +1;
		}

		private int right(int n)
		{
			return 2*n +2;
		}

		private int parent(int n)
		{
			return (n-1)/2;
		}

		private void swap(int p1, int p2)
		{
			var t = heap[p1];
			heap[p1] = heap[p2];
			heap[p2] = t;
		}

		private int maxChild(int pos)
		{
			var l = left(pos);
			var r = right(pos);
			if(r < size) //both child
			{
				return heap[l] >= heap[r] ? l : r;
			}
			else if (l < size) //only left child
			{
				return l;
			}
			else return -1;
		}

		private void maxHeapify(int pos) 
		{
			var mc = maxChild(pos);

			if(mc != -1 && heap[pos] < heap[mc])
			{
				swap(pos, mc);
				maxHeapify(mc);
			}
		}


	}
}