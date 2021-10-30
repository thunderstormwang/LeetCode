using System;

namespace LeetCode
{
    public class Solution0055
    {
        public bool CanJump(int[] nums)
        {
            var max = nums[0];

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > max)
                {
                    return false;
                }

                max = Math.Max(nums[i] + i,
                    max);
            }

            return max >= nums.Length - 1;
        }
    }
}