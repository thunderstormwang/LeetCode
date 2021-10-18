namespace LeetCode
{
    public class Solution0191
    {
        public int HammingWeight_Shift(uint n)
        {
            var result = 0;

            while (n > 0)
            {
                result += (int)(n & 1);
                n >>= 1;
            }

            return result;
        }

        public int HammingWeight_Divide(uint n)
        {
            var result = 0;

            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    result++;
                }
                n /= 2;
            }
            
            return result;
        }
    }
}