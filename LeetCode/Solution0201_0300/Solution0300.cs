namespace LeetCode.Solution0201_0300;

public class Solution0300
{
    public int LengthOfLIS_Ver1(int[] nums)
    {
        var result = 1;
        var dp = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
        }

        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }

                result = Math.Max(result, dp[i]);
            }
        }

        return result;
    }

    public int LengthOfLIS_Ver2(int[] nums)
    {
        var list = new List<int>();
        list.Add(nums[0]);

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] < list[0])
            {
                list[0] = nums[i];
                continue;
            }

            if (nums[i] > list[list.Count - 1])
            {
                list.Add(nums[i]);
                continue;
            }

            var left = 0;
            var right = list.Count - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;

                if (nums[i] > list[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            list[right] = nums[i];
        }

        return list.Count;
    }
}