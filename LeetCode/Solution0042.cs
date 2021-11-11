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
        
        // 用暴力法
        // 在每個 index 分別往左往右找最高點, 再計算該點能容納多少雨量
        // 我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化
        // Time: O(N^2)
        // Space: O(1)
        
        // 用 Dynamic Programming
        // 我看了提示後, 第一個想的法方法
        // 往右邊開始將最高點儲存到 stack
        // 然後從左到右, 逐一計算每個點能容納多少雨量
        // stack 的第一個元素都代表往右的最高點, 而左邊的最高點只要記住目前最高點即可取得
        // Time: O(N)
        // Space: O(N)
    }
}