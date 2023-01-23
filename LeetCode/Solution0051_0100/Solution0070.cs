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
                result += pre;
                pre = temp;
            }

            return result;
        }
    }
}