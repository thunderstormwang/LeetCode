using System.Text;

namespace LeetCode.Solution0301_0500;

public class Solution0394
{
    public string DecodeString(string s) {
        var countStack = new Stack<int>();
        var strStack = new Stack<StringBuilder>();
        var index = 0;
        var number = 0;

        while(index < s.Length)
        {
            if(s[index] >= '0' && s[index] <= '9')
            {
                number = 10 * number + (s[index] - '0');
            }

            if(s[index] == '[')
            {
                countStack.Push(number);
                strStack.Push(new StringBuilder());
                number = 0;
            }

            if(s[index] >= 'a' && s[index] <= 'z')
            {
                if(strStack.Count == 0)
                {
                    strStack.Push(new StringBuilder());
                }

                strStack.Peek().Append(s[index]);
            }

            if(s[index] == ']')
            {
                var curr = strStack.Pop();
                var count = countStack.Pop();

                if(strStack.Count == 0)
                {
                    strStack.Push(new StringBuilder());
                }

                while(count > 0)
                {
                    strStack.Peek().Append(curr.ToString());
                    count--;
                }
            }

            index++;
        }

        return strStack.Peek().ToString();
    }
}