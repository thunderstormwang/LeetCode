namespace LeetCode.Solution0001_0050;

public class Solution0032
{
    public int LongestValidParentheses(string s)
    {
        var result = 0;
        var stack = new Stack<int>();
        var start = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }

            if (s[i] == ')')
            {
                if (stack.Count == 0)
                {
                    start = i + 1;
                    continue;
                }

                stack.Pop();
                var temp = stack.Count == 0 ? i - start + 1 : i - stack.Peek();
                result = Math.Max(result, temp);
            }
        }

        return result;
    }
}