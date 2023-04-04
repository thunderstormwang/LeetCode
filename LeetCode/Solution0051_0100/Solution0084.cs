using System.Diagnostics;

namespace LeetCode.Solution0051_0100;

public class Solution0084
{
    public int LargestRectangleArea(int[] heights)
    {
        var result = 0;
        var stack = new Stack<int>();

        stack.Push(0);

        for (var i = 1; i < heights.Length; i++)
        {
            if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
                continue;
            }

            while (stack.Count != 0 && heights[i] < heights[stack.Peek()])
            {
                var pop = stack.Pop();
                var left = stack.Count == 0 ? 0 : stack.Peek() + 1;
                var right = i - 1;
                result = Math.Max(result, (right - left + 1) * heights[pop]);
            }

            stack.Push(i);
        }

        while (stack.Count != 0)
        {
            var pop = stack.Pop();
            var left = stack.Count == 0 ? 0 : stack.Peek() + 1;
            var right = heights.Length - 1;
            result = Math.Max(result, (right - left + 1) * heights[pop]);
        }

        return result;
    }
}