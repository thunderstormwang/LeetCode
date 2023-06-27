namespace LeetCode.Solution0501_0700;

public class Solution0503
{
    public int[] NextGreaterElements(int[] nums)
    {
        var result = new int[nums.Length];
        var stack = new Stack<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = -1;
        }

        stack.Push(0);
        for (var i = 1; i < 2 * nums.Length; i++)
        {
            while (stack.Count > 0)
            {
                var top = stack.Pop();

                if (nums[i % nums.Length] <= nums[top % nums.Length])
                {
                    stack.Push(top);
                    break;
                }

                result[top % nums.Length] = nums[i % nums.Length];
            }

            if (result[i % nums.Length] == -1)
            {
                stack.Push(i);
            }
        }

        return result;
    }
}