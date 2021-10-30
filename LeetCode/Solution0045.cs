using System;

namespace LeetCode
{
    public class Solution0045
    {
        public int Jump(int[] nums)
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
        
        // start: 在 nums[i] 能達到的最近距離
        // end: 在 nums[i] 能達到的最遠距離
        // maxFar: 從起點累計能達到的最遠距離
        
        // 從每次的 start ~ end 之間找能到最遠距離, 然後更新至 maxFar, 
        // 再更新 start, end, 直到 maxFar >= 傳入陣列長度 - 1
        // Time: O(N), Space: O(1)
    }
}