using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution0078
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            FindSubsets(nums,
                0,
                new List<int>(),
                result);

            return result;
        }

        private void FindSubsets(int[] nums,
            int index,
            IList<int> curr,
            IList<IList<int>> result)
        {
            result.Add(curr.ToArray());

            for (var i = index; i < nums.Length; i++)
            {
                curr.Add(nums[i]);
                FindSubsets(nums,
                    i + 1,
                    curr,
                    result);
                curr.Remove(nums[i]);
            }
        }
    }
}