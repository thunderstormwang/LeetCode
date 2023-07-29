namespace LeetCode.Solution0201_0300;

public class Solution0215
{
    public int FindKthLargest_Ver1(int[] nums, int k)
    {
        Array.Sort(nums);

        return nums[nums.Length - 1 - (k - 1)];
    }

    public int FindKthLargest_Ver2(int[] nums, int k)
    {
        var left = 0;
        var right = nums.Length - 1;

        var pos = Partition(nums, left, right);
        while (pos != k - 1)
        {
            if (pos > k - 1)
            {
                right = pos - 1;
                pos = Partition(nums, left, right);
            }

            if (pos < k - 1)
            {
                left = pos + 1;
                pos = Partition(nums, left, right);
            }
        }

        return nums[pos];
    }

    private int Partition(int[] nums, int start, int end)
    {
        var pivot = start;
        var left = start + 1;
        var right = end;

        while (left <= right)
        {
            while (right >= pivot && nums[right] < nums[pivot])
            {
                right--;
            }

            while (left <= end && nums[left] >= nums[pivot])
            {
                left++;
            }

            if (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
            }
        }

        (nums[pivot], nums[right]) = (nums[right], nums[pivot]);

        return right;
    }
}