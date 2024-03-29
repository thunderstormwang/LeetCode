﻿namespace LeetCode.Solution0001_0050;

public class Solution0042
{
    public int Trap_Ver1(int[] height)
    {
        var indexStack = new Stack<int>();
        var leftHeight = height[0];
        var rightHeight = 0;
        var result = 0;

        for (var i = height.Length - 1; i > 0; i--)
        {
            if (height[i] > height[i - 1] && rightHeight < height[i])
            {
                indexStack.Push(i);
                rightHeight = height[i];
            }
        }

        if (indexStack.Count == 0)
        {
            return 0;
        }

        for (var i = 1; i < height.Length - 1; i++)
        {
            var trapWater = Math.Min(leftHeight, rightHeight) - height[i];
            result += Math.Max(trapWater, 0);

            if (i == indexStack.Peek())
            {
                indexStack.Pop();
                if (indexStack.Count == 0)
                {
                    break;
                }

                rightHeight = height[indexStack.Peek()];
            }

            leftHeight = Math.Max(leftHeight, height[i]);
        }

        return result;
    }

    /// <summary>
    /// Monotonic Stack
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public int Trap_Ver2(int[] height)
    {
        var result = 0;
        var stack = new Stack<int>();

        for (var i = 0; i < height.Length; i++)
        {
            if (stack.Count == 0 || height[i] <= height[stack.Peek()])
            {
                stack.Push(i);
                continue;
            }

            while (stack.Count > 0 && height[stack.Peek()] < height[i])
            {
                if (stack.Count < 2)
                {
                    stack.Pop();
                    continue;
                }

                var curr = stack.Pop();
                var left = stack.Peek();
                var right = i;
                var minHeight = Math.Min(height[left], height[right]);
                result += (minHeight - height[curr]) * (right - left - 1);
            }

            stack.Push(i);
        }

        return result;
    }
}