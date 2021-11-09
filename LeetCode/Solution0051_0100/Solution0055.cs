using System;

namespace LeetCode.Solution0051_0100
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
    
    // 能否到第 n 個位置??
    // 最遠距離(nums[0] ~ nums[n-1]) 能否到 n ??
    // ...
    // 能否到第 i 個位置??
    // 最遠距離(nums[0] ~ nums[i-1]) 能否到 i ??
    // ...
    // 能否到第 2 個位置??
    // 最遠距離(nums[0] ~ nums[1]) 能否到 2 ??
    // ...
    // 能否到第 1 個位置??
    // 最遠距離(nums[0] ~ nums[0]) 能否到 1 ??

    //====

    // 能否到第 1 個位置??
    // 最遠距離(nums[0] ~ nums[0]) 能否到 1 ??
    // (0+ nums[0]) >= 1 ??
    // ...
    // 能否到第 2 個位置??
    // 最遠距離(nums[0] ~ nums[1]) 能否到 2 ??
    // MAX((0+nums[0], 1+nums[1]) >= 1 ??
    // ...
    // 能否到第 i 個位置??
    // 最遠距離(nums[0] ~ nums[i-1]) 能否到 i ??
    // MAX((0+nums[0], 1+nums[1], ... , i-1+nums[i-1]) >= i ??
    // ...
    // 能否到第 n 個位置??
    // 最遠距離(nums[0] ~ nums[n-1]) 能否到 n ??
    // MAX((0+nums[0], 1+nums[1], ... , n-1+nums[n-1]) >= n ??
    
    //=====

    // 跑一個迴圈計算
    // MAX((0+nums[0], 1+nums[1], ... , n-1+nums[n-1]) >= n ??
    // 同時也必須滿足
    // MAX((0+nums[0], 1+nums[1], ... , i-1+nums[i-1]) >= i ??
    
    // Time: O(N)
    // Space: O(1)
}