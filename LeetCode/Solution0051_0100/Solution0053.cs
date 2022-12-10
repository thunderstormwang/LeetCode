namespace LeetCode.Solution0051_0100
{
    public class Solution0053
    {
        public int MaxSubArray_DP(int[] nums)
        {
            var dp = new int[nums.Length];
            dp[0] = nums[0];
            var result = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
                result = Math.Max(dp[i], result);
            }

            return result;
        }

        public int MaxSubArray_Greedy(int[] nums)
        {
            var result = nums[0];
            var curr = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                curr = Math.Max(curr + nums[i], nums[i]);
                result = Math.Max(curr, result);
            }

            return result;
        }
    }
}