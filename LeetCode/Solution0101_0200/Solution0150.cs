using System;
using System.Collections.Generic;

namespace LeetCode.Solution0101_0200
{
    public class Solution0150
    {
        public int EvalRPN(string[] tokens)
        {
            var dict = new Dictionary<string, Func<int, int, int>>()
            {
                {
                    "+", (left, right) => left + right
                },
                {
                    "-", (left, right) => left - right
                },
                {
                    "*", (left, right) => left * right
                },
                {
                    "/", (left, right) => left / right
                }
            };

            var stack = new Stack<int>();

            foreach (var item in tokens)
            {
                if (dict.ContainsKey(item))
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push(dict[item](left, right));
                }
                else
                {
                    stack.Push(Convert.ToInt32(item));
                }
            }

            return stack.Pop();
        }
        
        // Time: O(N)
        // Space: O(N)
    }
}