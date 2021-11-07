namespace LeetCode.Solution0000_0050
{
    public class Solution0027
    {
        public int RemoveElement(int[] nums,
            int val)
        {
            var slow = 0;
            for (var fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] == val)
                {
                    continue;
                }

                (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
                slow++;
            }

            return slow;
        }

        // Time: O(N)
        // Space: O(1)
    }
}