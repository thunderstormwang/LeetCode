namespace LeetCode
{
    public class Solution136
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