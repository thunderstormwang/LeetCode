namespace LeetCode.Solution0201_9999
{
    public class Solution0509
    {
        public int Fib_NonRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            // F(0)
            var pre = 0;
            // F(1)
            var result = 1;

            for (var i = 2; i <= n; i++)
            {
                var temp = result;
                result = result + pre;
                pre = temp;
            }

            return result;
        }

        public int Fib_Recursive(int n)
        {
            return CalculateByRecursive(n,
                new int [n + 1]);
        }

        private int CalculateByRecursive(int n,
            int[] array)
        {
            if (n <= 1)
            {
                return n;
            }

            if (array[n] != 0)
            {
                return array[n];
            }

            array[n] = CalculateByRecursive(n - 1,
                array) + CalculateByRecursive(n - 2,
                array);

            return array[n];
        }
        
        // Non Recursive
        // Time: O(N)
        // Space: O(1)
        
        // =====
        
        // Recursive
        // Time: O(N^2)
        // Space: O(N)
    }
}