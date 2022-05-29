using System;

namespace LeetCode.Solution0201_0500
{
    public class Solution0209
    {
        public int MinSubArrayLen_Brutal(int target, int[] nums)
        {
            var result = int.MaxValue;
            for (var i = 0; i < nums.Length; i++)
            {
                var sum = 0;
                var tempLength = 0;
                for (var j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    tempLength++;
                    if (sum < target)
                    {
                        continue;
                    }

                    result = Math.Min(result, tempLength);
                    break;
                }
            }

            return result != int.MaxValue ? result : 0;
        }
        
        public int MinSubArrayLen_TwoPointer_Version1(int target, int[] nums)
        {
            var left = 0;
            var right = 0;
            var sum = 0;
            var result = 0;

            for (right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                if (target <= sum)
                {
                    break;
                }
            }

            if (right == nums.Length && sum < target)
            {
                return 0;
            }

            result = right + 1;

            left++;
            while (left < nums.Length && right < nums.Length)
            {
                sum -= nums[left - 1];
                sum -= nums[right];
                while (right < nums.Length)
                {
                    sum += nums[right];
                    if (target <= sum)
                    {
                        result = Math.Min(result, right - left + 1);
                        break;
                    }

                    right++;
                }

                left++;
            }

            return result;
        }

        public int MinSubArrayLen_TwoPointer_Version2(int target, int[] nums)
        {
            var left = 0;
            var right = 0;
            var sum = 0;
            var result = int.MaxValue;

            for (right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (target <= sum)
                {
                    result = Math.Min(result,
                        right - left + 1);
                    sum -= nums[left++];
                }
            }

            return result != int.MaxValue ? result : 0;
        }

        // 用暴力法
        // Time: O(N^2)
        // Space: O(1)

        //------------------------

        // 用 two pointer
        // 看到提示說使用 two pointer
        // version 1 是我一開始的想法: 是跑兩個迴圈,
        // 第一個迴圈, 設定 left 為 0, 往右找最小能符合 target <= sum 的 right
        // 第二個迴圈, 扣掉 nums[left], 再將 left + 1, 再右找最小能符合 target <= sum 的 right
        
        // version 2 看了別人的解答才知結果其實只要一個迴圈就可以了, 真另人汗顏
        
        // Time: O(N), 每個元素最多被走過兩次
        // Space: O(1)
    }
}