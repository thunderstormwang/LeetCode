namespace LeetCode
{
    public class Solution136
    {
        public int SingleNumber(int[] input)
        {
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result ^= input[i];
            }

            return result;
        }
    }
}