using System;

namespace LeetCode.Solution0051_0100
{
    public class Solution0053
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            var result = nums[0];
            var curr = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                curr = Math.Max(curr + nums[i], nums[i]);
                result = Math.Max(curr, result);
            }

            return result;
        }
        
        // 用暴力法
        // 一共用 n + (n-1) + ... + 1 個陣列
        // Time: O(n^2)
        
        // 用動態規劃
        // 想知道 1 ~ i 的最大子陣列和, 可以先從 1 ~ i-1 的最大子陣列和推算
        //   - 從 1 ~ i-1 的最大子陣列和
        //   - 從 1 ~ i-1 的子陣列和 + num[i]

        // curr: 包含當前元素的最大子陣列和
        // result: 到目前為止的最大子陣列和
        
        // Time: O(n)
        // Space: O(1)
    }
}