using System;

namespace LeetCode
{
    public class Solution0050
    {
        public double MyPow(double x, int n)
        {
            var result = 1d;

            if (n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            return CalculatePow(x, n);
        }

        private double CalculatePow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n == 1)
            {
                return x;
            }

            var half = CalculatePow(x, n / 2);

            return half * half * (n % 2 == 0 ? 1 : x);
        }
    }
}