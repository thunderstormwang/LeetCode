namespace LeetCode
{
    public class Solution0069
    {
        public int MySqrt(int x)
        {
            long result = x;
            while (result * result > x)
            {
                result = (int)((result + x / result) / 2);
            }
            return (int)result;
        }
    }
}