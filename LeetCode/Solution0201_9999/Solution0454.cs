using System.Collections.Generic;

namespace LeetCode.Solution0201_9999
{
    public class Solution0454
    {
        public int FourSumCount(int[] nums1,
            int[] nums2,
            int[] nums3,
            int[] nums4)
        {
            var result = 0;
            var dict = new Dictionary<int, int>();
            foreach (var item1 in nums1)
            {
                foreach (var item2 in nums2)
                {
                    if (!dict.ContainsKey(item1 + item2))
                    {
                        dict[item1 + item2] = 0;
                    }

                    dict[item1 + item2]++;
                }
            }

            foreach (var item3 in nums3)
            {
                foreach (var item4 in nums4)
                {
                    if (dict.ContainsKey(0 - (item3+item4)))
                    {
                        result += dict[0 - (item3 + item4)];
                    }
                }
            }

            return result;
        }

        // Time: O(N^2)
        // Space: O(N^2)
    }
}