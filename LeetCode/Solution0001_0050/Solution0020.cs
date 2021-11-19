using System.Collections.Generic;

namespace LeetCode.Solution0001_0050
{
    public class Solution0020
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };

            foreach (var item in s)
            {
                if (dict.ContainsKey(item))
                {
                    stack.Push(dict[item]);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    var pop = stack.Pop();
                    if (item != pop)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        // Time: O(N)
        // Space: O(N)
    }
}