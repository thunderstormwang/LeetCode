﻿namespace LeetCode.Solution0701_9999;

public class Solution0704
{
    public int Search_Recursive(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    public int Search_Iterative(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var half = (start + end) / 2;
            if (nums[half] == target)
            {
                return half;
            }

            if (nums[half] < target)
            {
                start = half + 1;
            }
            else
            {
                end = half - 1;
            }
        }

        return -1;
    }

    private int BinarySearch(int[] nums, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }

        var half = (start + end) / 2;

        if (nums[half] == target)
        {
            return half;
        }

        if (nums[half] < target)
        {
            return BinarySearch(nums, target, half + 1, end);
        }
        else
        {
            return BinarySearch(nums, target, start, half - 1);
        }
    }
}