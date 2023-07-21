namespace LeetCode.Solution0201_0300;

public class Solution0224
{
    public int Calculate(string s)
    {
        var result = 0;
        var sign = 1;
        var stack = new Stack<int>();
        var index = 0;

        while (index < s.Length)
        {
            if (s[index] >= '0' && s[index] <= '9')
            {
                var i = index;

                while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                {
                    i++;
                }

                var temp = int.Parse(s.Substring(index, i - index));
                result += sign * temp;

                index = i;
                continue;
            }

            if (s[index] == '+')
            {
                sign = 1;
            }

            if (s[index] == '-')
            {
                sign = -1;
            }

            if (s[index] == '(')
            {
                stack.Push(result);
                stack.Push(sign);
                result = 0;
                sign = 1;
            }

            if (s[index] == ')')
            {
                result *= stack.Pop();
                result += stack.Pop();
            }

            index++;
        }


        return result;
    }
}