using System;

namespace LeetCode
{
    public class Solution53
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            int result = nums[0];
            int temp = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                temp = Math.Max(temp + nums[i], nums[i]);
                result = Math.Max(temp, result);
                Console.WriteLine(string.Format("temp: {0}, result: {1}", temp, result));
            }

            return result;
        }
    }
}