namespace LeetCode.Solution0001_0050;

public class Solution0033
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (target == nums[middle])
            {
                return middle;
            }

            if (nums[middle] < nums[right])
            {
                if (nums[middle] <= target && target <= nums[right])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            else
            {
                if (nums[left] <= target && target <= nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
        }

        return -1;
    }
}