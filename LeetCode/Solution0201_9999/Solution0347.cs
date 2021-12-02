using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0201_9999
{
    public class Solution0347
    {
        private class Comp : IComparer<KeyValuePair<int, int>>
        {
            public int Compare(KeyValuePair<int, int> x,
                KeyValuePair<int, int> y)
            {
                return x.Value == y.Value ? x.Key.CompareTo(y.Key) : x.Value.CompareTo(y.Value);
            }
        }

        public int[] TopKFrequentTest(int[] nums,
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

            var set = new SortedSet<KeyValuePair<int, int>>(new Comp());
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

        // 用 Dictionary
        // Time: O(N) + O(N*log(N)) = O(N*log(N))
        // Space: O(N)
    }
}