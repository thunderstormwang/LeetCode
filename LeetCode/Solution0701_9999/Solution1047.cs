using System.Text;

namespace LeetCode.Solution0701_9999
{
    public class Solution1047
    {
        public string RemoveDuplicates_Version1(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (stack.Count == 0 || stack.Peek() != item)
                {
                    stack.Push(item);
                }
                else
                {
                    stack.Pop();
                }
            }

            var sBuilder = new StringBuilder();
            while (stack.Count != 0)
            {
                sBuilder.Insert(0, stack.Pop());
            }

            return sBuilder.ToString();
        }

        public string RemoveDuplicates_Version2(string s)
        {
            var sBuilder = new StringBuilder();
            foreach (var item in s)
            {
                if (sBuilder.Length == 0)
                {
                    sBuilder.Append(item);
                    continue;
                }

                if (sBuilder[sBuilder.Length - 1] == item)
                {
                    sBuilder.Remove(sBuilder.Length - 1, 1);
                    continue;
                }

                sBuilder.Append(item);
            }

            return sBuilder.ToString();
        }

        // version 1
        // Time: O(M)
        // Space: O(N)

        // =======

        // version 1
        // Time: O(M)
        // Space: O(N)
    }
}