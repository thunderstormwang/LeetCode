using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0201_9999
{
    public class Solution0347
    {
        public int[] TopKFrequentTest_SortedSet(int[] nums,
            int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }

                dict[item]++;
            }

            var set = new SortedSet<KeyValuePair<int, int>>(new Comparer());
            foreach (var item in dict)
            {
                set.Add(item);
                if (set.Count > k)
                {
                    set.Remove(set.Min);
                }
            }

            return set.Select(s => s.Key).ToArray();
        }

        public int[] TopKFrequentTest_HeapArray(int[] nums,
            int k)
        {
            var result = new int [k];
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }

                dict[item]++;
            }

            var heap = new MinHeap(k,
                (x,
                    y) => dict[x] < dict[y] ? 1 : -1);
            foreach (var item in dict)
            {
                heap.Insert(item.Key);
            }

            Array.Copy(heap.Array,
                result,
                k);
            return result;
        }

        private class MinHeap
        {
            /// <summary>
            /// return 1 when x is less than y, or return -1 when other situation 
            /// </summary>
            private readonly Func<int, int, int> _comparer;

            private int _curr;

            public readonly int[] Array;

            public MinHeap(int size,
                Func<int, int, int> comparer)
            {
                _curr = -1;
                Array = new int[size + 1];
                this._comparer = comparer;
            }

            public void Insert(int input)
            {
                Array[++_curr] = input;
                HeapifyUp(_curr);

                if (_curr == Array.Length - 1)
                {
                    DeleteMin();
                }
            }

            public void DeleteMin()
            {
                (Array[0], Array[_curr]) = (Array[_curr], Array[0]);
                _curr--;
                HeapifyDown(0);
            }

            private void HeapifyDown(int index)
            {
                var left = 2 * index + 1;
                var right = 2 * index + 2;
                var target = index;

                if (left <= _curr)
                {
                    target = _comparer(Array[target],
                        Array[left]) >= 1
                        ? target
                        : left;
                }

                if (right <= _curr)
                {
                    target = _comparer(Array[target],
                        Array[right]) >= 1
                        ? target
                        : right;
                }

                if (target != index)
                {
                    (Array[index], Array[target]) = (Array[target], Array[index]);
                    HeapifyDown(target);
                }
            }

            private void HeapifyUp(int index)
            {
                var parent = (index - 1) / 2;

                if (_comparer(Array[index],
                    Array[parent]) == 1)
                {
                    (Array[index], Array[parent]) = (Array[parent], Array[index]);
                    HeapifyUp(parent);
                }
            }
        }

        private class Comparer : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x,
                KeyValuePair<int, int> y)
            {
                return x.Value == y.Value ? x.Key.CompareTo(y.Key) : x.Value.CompareTo(y.Value);
            }
        }

        // Time: O(N) + O(N*log(k)) = O(N) 
        // Space: O(N+k), N: Dictionary 的空間, k: SortedSet 的空間
    }
}