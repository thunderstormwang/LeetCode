namespace LeetCode.Solution0051_0100;

public class Solution0084
{
    public int LargestRectangleArea(int[] heights)
    {
        var result = 0;
        var stack = new Stack<int>();

        for (var i = 0; i < heights.Length; i++)
        {
            if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
                continue;
            }

            while (stack.Count != 0 && heights[i] < heights[stack.Peek()])
            {
                var curr = stack.Pop();
                var left = stack.Count == 0 ? 0 : stack.Peek() + 1;
                var right = i - 1;
                result = Math.Max(result, (right - left + 1) * heights[curr]);
            }

            stack.Push(i);
        }

        while (stack.Count != 0)
        {
            var curr = stack.Pop();
            var left = stack.Count == 0 ? 0 : stack.Peek() + 1;
            var right = heights.Length - 1;
            result = Math.Max(result, (right - left + 1) * heights[curr]);
        }

        return result;
    }
}