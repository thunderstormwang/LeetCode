using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution0491
    {
        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            FindIncreasingSubsequences(nums,
                0,
                new List<int>(),
                result);

            return result;
        }

        private void FindIncreasingSubsequences(int[] nums,
            int index,
            IList<int> curr,
            IList<IList<int>> result)
        {
            var notInChoice = new HashSet<int>();
            for (var i = index; i < nums.Length; i++)
            {
                if (curr.Count != 0 && curr.Last() > nums[i])
                {
                    continue;
                }

                if (notInChoice.Contains(nums[i]))
                {
                    continue;
                }

                curr.Add(nums[i]);
                if (curr.Count >= 2)
                {
                    result.Add(curr.ToArray());
                }

                FindIncreasingSubsequences(nums,
                    i + 1,
                    curr,
                    result);
                curr.RemoveAt(curr.Count - 1);
                notInChoice.Add(nums[i]);
            }
        }
    }
}