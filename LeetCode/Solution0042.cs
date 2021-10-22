using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution0042
    {
        public int Trap(int[] height)
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
                var trapWater = Math.Min(leftHeight,
                    rightHeight) - height[i];
                result += Math.Max(trapWater,
                    0);

                if (i == indexStack.Peek())
                {
                    indexStack.Pop();
                    if (indexStack.Count == 0)
                    {
                        break;
                    }

                    rightHeight = height[indexStack.Peek()];
                }

                leftHeight = Math.Max(leftHeight,
                    height[i]);
            }

            return result;
        }
    }
}