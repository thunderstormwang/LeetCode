namespace LeetCode.Solution0501_9999;

public class Solution1005
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums);

        var index = 0;

        while (k > 0 && index < nums.Length)
        {
            if (nums[index] >= 0)
            {
                index++;
                continue;
            }
            
            nums[index] = -1 * nums[index];
            index++;
            k--;
        }

        if (k % 2 == 1)
        {
            // nums 全都轉為正數, k 仍有剩
            var min = Int32.MaxValue;
            var minIndex = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (min <= nums[i])
                {
                    continue;
                }
                
                min = nums[i];
                minIndex = i;
            }

            nums[minIndex] = -1 * nums[minIndex];
        }

        return nums.Sum();
    }
    
    public int LargestSumAfterKNegations_SortByAbs(int[] nums, int k)
    {
        Array.Sort(nums, (x, y) =>
        {
            if (Math.Abs(x) == Math.Abs(y))
            {
                return 0;
            }

            return Math.Abs(x) < Math.Abs(y) ? -1 : 1;
        });

        for (var i = nums.Length - 1; i >= 0 && k > 0; i--)
        {
            if (nums[i] > 0)
            {
                continue;
            }
            
            nums[i] = -1 * nums[i];
            k--;
        }

        if (k % 2 == 1)
        {
            // nums 全都轉為正數, k 仍有剩
            nums[0] = -1 * nums[0];
        }

        return nums.Sum();
    }
}