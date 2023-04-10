namespace LeetCode.Solution0501_9999;

public class Solution0525
{
    public int FindMaxLength(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        var result = 0;
        var sum = 0;
        dict.Add(0, -1);

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                sum--;
            }

            if (nums[i] == 1)
            {
                sum++;
            }

            if (!dict.ContainsKey(sum))
            {
                dict.Add(sum, i);
                continue;
            }

            result = Math.Max(result, i - dict[sum]);
        }

        return result;
    }
}