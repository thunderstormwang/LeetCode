namespace LeetCode.Solution0001_0050
{
    public class Solution0031
    {
        public void NextPermutation(int[] nums)
        {
            var decreasingIndex = -1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] >= nums[i + 1])
                {
                    continue;
                }

                decreasingIndex = i;
                break;
            }

            if (decreasingIndex != -1)
            {
                var justLargerIndex = 0;
                for (var i = nums.Length - 1; i >= 0; i--)
                {
                    if (nums[i] <= nums[decreasingIndex])
                    {
                        continue;
                    }

                    justLargerIndex = i;
                    break;
                }

                (nums[decreasingIndex], nums[justLargerIndex]) = (nums[justLargerIndex], nums[decreasingIndex]);
            }

            var startIndex = decreasingIndex + 1;
            var endIndex = nums.Length - 1;
            while (startIndex < endIndex)
            {
                (nums[startIndex], nums[endIndex]) =
                    (nums[endIndex], nums[startIndex]);
                startIndex++;
                endIndex--;
            }
        }
        
        // 用暴力法
        // Time: O(N!)
        // Space: O(N)
        
        // 官方解法
        // Time: O(N)
        // Space: O(1)
    }
}