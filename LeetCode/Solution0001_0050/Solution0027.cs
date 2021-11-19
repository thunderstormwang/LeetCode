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
        
        // 用暴力法, 兩個巢狀迴圈, 第一個迴圈找要移除的元素, 第二個迴圈將該元素之後的所有元素的位置都往前移一格
        // Time: O(N^2)
        // Space: O(1)
        
        //------------------------

        // 用 two pointer
        // Time: O(N)
        // Space: O(1)
    }
}