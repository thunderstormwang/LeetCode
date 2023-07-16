namespace LeetCode.Solution0001_0050;

public class Solution0020
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        for(var i = 0; i < s.Length; i++)
        {
            if(!dict.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }

            if(stack.Count == 0)
            {
                return false;
            }

            var temp = stack.Pop();

            if(dict[s[i]] != temp)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}