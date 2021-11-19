using System;

namespace LeetCode.Solution0001_0050
{
    public class Solution0011
    {
        public int MaxArea(int[] height)
        {
            var lowIndex = 0;
            var highIndex = height.Length - 1;
            var result = 0;

            while (lowIndex < highIndex)
            {
                var currHeight = Math.Min(height[lowIndex],
                    height[highIndex]);
                var area = currHeight * (highIndex - lowIndex);
                result = Math.Max(result,
                    area);

                if (height[lowIndex] < height[highIndex])
                {
                    lowIndex++;
                }
                else
                {
                    highIndex--;
                }
            }

            return result;
        }
        
        // 用暴力法, (n-1) + (n-2) + ... + 1
        // Time: O(N^2)
        // Space: O(1)
        
        //------------------------
        
        // 用 two pointer, 從最左邊和最右邊開始,
        // 計算完容量後, 將較矮的一端往內移動, 因為移動較高的肯定不會得到更多的容量
        // Time: O(N^2)
        // Space: O(1)
    }
}