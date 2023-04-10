namespace LeetCode.Solution0301_0500;

public class Solution0496
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];
        var stack = new Stack<int>();
        var dict = new Dictionary<int, int>();

        dict[nums2[0]] = -1;
        stack.Push(nums2[0]);
        for (var i = 1; i < nums2.Length; i++)
        {
            while (stack.Count > 0)
            {
                var top = stack.Peek();

                if (nums2[i] < top)
                {
                    break;
                }
                
                stack.Pop();
                dict[top] = nums2[i];
            }

            dict[nums2[i]] = -1;
            stack.Push(nums2[i]);
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            result[i] = dict[nums1[i]];
        }

        return result;
    }
}