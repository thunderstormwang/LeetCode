namespace LeetCode
{
    public class Solution0136
    {
        public int SingleNumber(int[] input)
        {
            var result = 0;

            foreach (var item in input)
            {
                result ^= item;
            }

            return result;
        }
    }
}