namespace LeetCode.Solution0501_0700
{
    public class Solution0509
    {
        public int Fib_Iterative_Ver1(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            var dp = new int [n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 2] + dp[i - 1];
            }

            return dp[n];
        }
        
        public int Fib_Iterative_Ver2(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            var pre = 0;
            var result = 1;

            for (var i = 2; i <= n; i++)
            {
                var temp = result;
                result += pre;
                pre = temp;
            }

            return result;
        }
        
        public int Fib_Recursive_Ver1(int n)
        {
            return Recursive_Ver1(n);
        }

        private int Recursive_Ver1(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Recursive_Ver1(n - 2) + Recursive_Ver1(n - 1);
        }

        public int Fib_Recursive_Ver2(int n)
        {
            return Recursive_Ver2(n, new int [n + 1]);
        }

        private int Recursive_Ver2(int n, int[] array)
        {
            if (n <= 1)
            {
                return n;
            }

            if (array[n] != 0)
            {
                return array[n];
            }

            array[n] = Recursive_Ver2(n - 1, array) + Recursive_Ver2(n - 2, array);

            return array[n];
        }
    }
}