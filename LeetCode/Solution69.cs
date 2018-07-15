namespace LeetCode
{
    public class Solution69
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