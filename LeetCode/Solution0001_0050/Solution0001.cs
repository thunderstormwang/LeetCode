namespace LeetCode.Solution0001_0050;

public class Solution0001
{
    public int[] TwoSum(int[] nums, int target)
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

            dict.Add(input, i);
        }

        return new int[] { dict[pairIndex], i };
    }
}