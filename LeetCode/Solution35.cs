﻿namespace LeetCode
{
    public class Solution35
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}