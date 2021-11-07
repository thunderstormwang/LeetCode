using System;

namespace LeetCode.Solution0000_0050
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
            var fast = 0;

            for (slow = 1; slow < nums.Length && fast < nums.Length; slow++)
            {
                if (nums[slow] > nums[slow - 1])
                {
                    continue;
                }

                while (fast < nums.Length && nums[fast] <= nums[slow - 1])
                {
                    fast++;
                }

                if (fast >= nums.Length)
                {
                    return slow;
                }

                (nums[slow], nums[fast]) = (nums[fast], nums[slow]);
                fast++;
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

            var index = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[index] == nums[i])
                {
                    continue;
                }

                nums[index + 1] = nums[i];
                index++;
            }

            return index + 1;
        }

        // 官方給的解法簡潔許多
        // index 為當前被比較的值的索引值
        // 跳過所有的重複值, 將第一個不重複的值放在 index + 1 的位置
        // 然後將 index + 1
        // 直到將陣列走完

        // Time: O(N)
        // Space: O(1)
    }
}