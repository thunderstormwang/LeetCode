namespace LeetCode.Solution0101_0150;

public class Solution0136
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;

        for(var i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result; 
    }
}