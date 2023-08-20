namespace LeetCode.Solution0201_0300;

public class Solution0268
{
    public int MissingNumber_Ver1(int[] nums)
    {
        var expectedSum = nums.Length * (nums.Length + 1) / 2;
        var realSum = nums.Sum();

        return expectedSum - realSum;
    }

    public int MissingNumber_Ver2(int[] nums)
    {
        var result = 0;

        for (var i = 1; i <= nums.Length; i++)
        {
            result = result ^ i ^ nums[i - 1];
        }

        return result;
    }
}