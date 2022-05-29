using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution0090
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            FindSubsetsWithDup(nums, 0, new List<int>(), result);

            return result;
        }

        private void FindSubsetsWithDup(int[] nums, int index, IList<int> curr, IList<IList<int>> result)
        {
            result.Add(curr.ToArray());

            for (var i = index; i < nums.Length; i++)
            {
                if (i > index && i < nums.Length && nums[i - 1] == nums[i])
                {
                    continue;
                }

                curr.Add(nums[i]);
                FindSubsetsWithDup(nums, i + 1, curr, result);
                curr.Remove(nums[i]);
            }
        }
    }
}