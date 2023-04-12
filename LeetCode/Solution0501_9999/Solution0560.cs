namespace LeetCode.Solution0501_9999;

public class Solution0560
{
    public int SubarraySum_Brutal_Ver1(int[] nums, int k) 
    {
        var result = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            for (var j = i; j < nums.Length; j++)
            {
                var sum = 0;
                for (var m = i; m <= j; m++)
                {
                    sum += nums[m];
                }

                if (sum == k)
                {
                    result++;
                }
            }

        }

        return result;
    }
    
    public int SubarraySum_Brutal_Ver2(int[] nums, int k) 
    {
        var result = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            var sum = nums[i];
            if(sum == k)
            {
                result++;
            }

            for(var j = i + 1; j < nums.Length; j++)
            {
                sum+= nums[j];
                if(sum == k)
                {
                    result++;
                }
            }
        }

        return result;
    }
    
    public int SubarraySum_Dictionary(int[] nums, int k)
    {
        var result = 0;
        var sum = 0;
        var dict = new Dictionary<int, int>();
        dict.Add(0, 1);

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            var target = sum - k;

            if (dict.ContainsKey(target))
            {
                result += dict[target];
            }

            if (dict.ContainsKey(sum))
            {
                dict[sum]++;
            }
            else
            {
                dict.Add(sum, 1);
            }
        }

        return result;
    }
}