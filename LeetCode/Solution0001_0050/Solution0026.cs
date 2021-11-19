using System;

namespace LeetCode.Solution0001_0050
{
    public class Solution0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            var slow = 0;
            for (slow = 1; slow < nums.Length; slow++)
            {
                if (nums[slow - 1] < nums[slow])
                {
                    continue;
                }

                var fast = slow + 1;
                while (fast < nums.Length && nums[fast] <= nums[slow - 1])
                {
                    fast++;
                }

                if (fast >= nums.Length)
                {
                    return slow;
                }

                (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
            }

            return slow;
        }

        // Time: O(N)
        // Space: O(1)

        public int RemoveDuplicates_Official(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            var slow = 0;
            for (var fast = 1; fast < nums.Length; fast++)
            {
                if (nums[slow] == nums[fast])
                {
                    continue;
                }

                nums[slow + 1] = nums[fast];
                slow++;
            }

            return slow + 1;
        }

        // 官方給的解法簡潔許多
        // slow 為當前被比較的值的索引值
        // 跳過所有的重複值, 將第一個不重複的值放在 slow + 1 的位置
        // 然後將 slow + 1
        // 直到將陣列走完

        // Time: O(N)
        // Space: O(1)
    }
}