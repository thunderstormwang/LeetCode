namespace LeetCode
{
    public class Solution70
    {
        public int ClimbStairs(int n)
        {
            // f(x) = f(x-1) + f(x-2)

            if (n == 1 || n == 2)
            {
                return n;
            }

            var array = new int[n];

            // f(1) = 1
            array[0] = 1;
            // f(2) = 2
            array[1] = 2;

            for (var i = 2; i < n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n - 1];
        }
    }
}