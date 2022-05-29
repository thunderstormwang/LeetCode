using System;

namespace LeetCode
{
    public class Solution0029
    {
        public int Divide(int dividend,
            int divisor)
        {
            var a = int.MaxValue;
            var b = a + 1;

            if (dividend == 0)
            {
                return 0;
            }

            var result = 0;
            if (dividend > 0)
            {
                while (dividend >= 0)
                {
                    if (dividend - divisor > dividend)
                    {
                        dividend += divisor;
                        result -= 1;
                        continue;
                    }

                    dividend -= divisor;
                    result += 1;
                }
            }
            else
            {
                while (dividend <= 0)
                {
                    if (dividend + divisor < dividend)
                    {
                        dividend -= divisor;
                        result += 1;
                        continue;
                    }

                    dividend += divisor;
                    result -= 1;
                }
            }

            return result > 0 ? result - 1 : result + 1;
        }
    }
}