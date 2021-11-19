using System.Collections.Generic;

namespace LeetCode.Solution0001_0050
{
    public class Solution0001
    {
        public int[] TwoSum(int[] nums,
            int target)
        {
            var dict = new Dictionary<int, int>();
            var i = 0;
            var pairIndex = 0;

            for (i = 0; i < nums.Length; i++)
            {
                var input = nums[i];
                pairIndex = target - input;
                if (dict.ContainsKey(pairIndex))
                {
                    break;
                }

                dict.Add(input,
                    i);
            }

            return new int[] { dict[pairIndex], i };
        }
        
        // 用暴力法, 在陣列 nums 裡尋找能跟 nums[i] 配對的數字
        // Time: O(N^2)
        // Space: O(1)
        
        //------------------------
        
        // 用 hash table 儲存每個找過的 nums[i]
        // Time: O(N)
        // Space: O(N)
    }
}