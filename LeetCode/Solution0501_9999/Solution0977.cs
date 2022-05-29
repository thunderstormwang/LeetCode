using System;

namespace LeetCode.Solution0501_9999
{
    public class Solution0977
    {
        public int[] SortedSquares(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = new int [nums.Length];
            var index = nums.Length - 1;

            while (left <= right)
            {
                var leftPower = (int)Math.Pow(nums[left], 2);
                var rightPower = (int)Math.Pow(nums[right], 2);
                if (leftPower >= rightPower)
                {
                    result[index--] = leftPower;
                    left++;
                }
                else
                {
                    result[index--] = rightPower;
                    right--;
                }
            }

            return result;
        }

        // 用暴力法, 所有元素做了平方後再作排序
        // Time: O(N + N*logN)
        // Space: O(N)

        //------------------------

        // 用 two pointer
        // 我一開始的想法是從小到大開始排, 所以先找到最接近 0 的元素的位置, 然後兩個指標各別從左往外找、從右往外找
        // 看了解答才知道若是從最大開始排, 那就可以從兩端開始往內找, 更單純
        // Time: O(N)
        // Space: O(N)
    }
}