namespace LeetCode.Solution0001_0050;

public class Solution0041
{
    public int FirstMissingPositive(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= 0 || nums[i] > nums.Length)
            {
                continue;
            }

            if (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
            {
                var temp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[temp - 1] = temp;
                i--;
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}