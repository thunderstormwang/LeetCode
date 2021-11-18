namespace LeetCode.Solution0051_0100
{
    public class Solution0070
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            // f(1) = 1
            var pre = 1;
            // f(2) = 2
            var result = 2;

            for (var i = 2; i < n; i++)
            {
                var temp = result;
                result = result + pre;
                pre = temp;
            }

            return result;
        }
        
        // dp[n] = dp[n-2] + dp[n-1]
        // 可以用陣列記住每一步的結果, 不過如果只要第 n 的結果的話, 不必用到陣列 
        
        // Time: O(N)
        // Space: O(1)
    }
}