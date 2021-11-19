using System;

namespace LeetCode.Solution0001_0050
{
    public class Solution0007
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }
            var result = 0;
            var isNegative = x < 0;
            x = Math.Abs(x);
            
            while (x > 0)
            {
                if (result > 214748364)
                {
                    return 0;
                }
                result *= 10;
                result += x % 10;
                x /= 10;
            }

            result *= isNegative ? -1 : 1;
            return result;
        }
        
        // Time: O(log(n))
        // Space: O(1)
    }
}