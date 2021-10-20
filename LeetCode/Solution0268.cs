namespace LeetCode
{
    public class Solution0268
    {
        public int MissingNumber(int[] nums)
        {
            var result = 0;
            for (var i = 1; i <= nums.Length; i++)
            {
                result = result ^ i ^ nums[i-1];
            }

            return result;
        }
    }
}