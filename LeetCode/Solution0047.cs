using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0047
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            FindByRecursivie(result, 0, nums);

            return result;
        }

        private void FindByRecursivie(IList<IList<int>> result, int index, int[] nums)
        {
            if (index == nums.Length)
            {
                result.Add(new List<int>(nums));
            }

            var used = new HashSet<int>();

            for (var i = index; i < nums.Length; i++)
            {
                if (!used.Add(nums[i]))
                {
                    continue;
                }

                (nums[i], nums[index]) = (nums[index], nums[i]);

                FindByRecursivie(result,
                    index + 1,
                    nums);

                (nums[i], nums[index]) = (nums[index], nums[i]);
            }
        }
    }
}