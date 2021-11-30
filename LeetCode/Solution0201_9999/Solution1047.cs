using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solution0201_9999
{
    public class Solution1047
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                    continue;
                }

                if (stack.Peek() == item)
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(item);
            }

            var sBuilder = new StringBuilder();
            while (stack.Count != 0)
            {
                sBuilder.Insert(0, stack.Pop());
            }

            return sBuilder.ToString();
        }
    }
}