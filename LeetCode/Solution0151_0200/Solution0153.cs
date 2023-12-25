namespace LeetCode.Solution0151_0200;

public class Solution0153
{
    public int FindMin_Ver1(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (right - left >= 2)
        {
            var middle = (left + right) / 2;
            if (nums[left] < nums[middle] && nums[middle] < nums[right])
            {
                right = middle;
            }
            else if (nums[middle] < nums[right] && nums[right] < nums[left])
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
        }

        return nums[left] < nums[right] ? nums[left] : nums[right];
    }
    
    public int FindMin_Ver2(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;
            if (nums[middle] <= nums[right])
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return nums[right];
    }
}