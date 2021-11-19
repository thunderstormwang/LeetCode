using System;

namespace LeetCode.Solution0000_0050
{
    public class Solution0045
    {
        public int Jump_DynamicProgramming(int[] nums)
        {
            var dp = new int[nums.Length];
            dp[0] = 0;
            for (var i = 1; i < dp.Length; i++)
            {
                dp[i] = int.MaxValue;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var start = i + 1;
                var end = i + nums[i];
                for (var j = start; j <= end && j < nums.Length; j++)
                {
                    dp[j] = Math.Min(dp[j],
                        dp[i] + 1);
                }
            }

            return dp[dp.Length - 1];
        }

        public int Jump_Greedy(int[] nums)
        {
            var start = 0;
            var end = 0;
            var maxFar = 0;
            var step = 0;

            while (maxFar < nums.Length - 1)
            {
                step++;
                for (var i = start; i <= end; i++)
                {
                    maxFar = Math.Max(i + nums[i],
                        maxFar);
                }

                start = end + 1;
                end = maxFar;
            }

            return step;
        }

        // 用動態規劃, 但以這題不是最佳解
        // 到 index n 的最少 jump
        // => min(在 index 0 ~ index n-1 所有能跳到 n 的 index, 到達自身的最小 jump) + 1
        // ...
        // 到 index i 的最少 jump
        // => min(在 index 0 ~ index i-1 所有能跳到 i 的 index, 到達自身的最小 jump) + 1
        // ...
        // 到 index 1 的最少 jump
        // => min(在 index 0 ~ index 0 所有能跳到 1 的 index, 到達自身的最小 jump) + 1 
        // => 1
        // ...
        // 到 index 0 的最少 jump
        // => 0

        // ======

        // 用 greedy
        // start: 在 nums[i] 能達到的最近距離
        // end: 在 nums[i] 能達到的最遠距離
        // maxFar: 從起點累計能達到的最遠距離

        // 從每次的 start ~ end 之間找能到最遠距離, 然後更新至 maxFar, 
        // 再更新 start, end, 直到 maxFar >= 傳入陣列長度 - 1
        // Time: O(N)
        // Space: O(1)
    }
}