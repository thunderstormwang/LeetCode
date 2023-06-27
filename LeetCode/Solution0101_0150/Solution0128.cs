namespace LeetCode.Solution0101_0150;

public class Solution0128
{
    public int LongestConsecutive_Ver1(int[] nums)
    {
        var result = 0;
        var hashSet = new HashSet<int>();
        foreach (var element in nums)
        {
            hashSet.Add(element);
        }

        foreach (var element in hashSet)
        {
            if (hashSet.Contains(element - 1))
            {
                continue;
            }

            var currCount = 1;
            var currNum = element;
            while (hashSet.Contains(currNum + 1))
            {
                currCount++;
                currNum++;
            }

            result = Math.Max(result, currCount);
        }

        return result;
    }

    public int LongestConsecutive_Ver2(int[] nums)
    {
        var result = 0;
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                continue;
            }

            var left = dict.ContainsKey(nums[i] - 1) ? dict[nums[i] - 1] : 0;
            var right = dict.ContainsKey(nums[i] + 1) ? dict[nums[i] + 1] : 0;
            var count = left + 1 + right;

            result = Math.Max(result, count);
            
            dict.Add(nums[i], count);
            dict[nums[i] - left] = count;
            dict[nums[i] + right] = count;
        }

        return result;
    }
}