namespace LeetCode.Solution0201_0300;

public class Solution0227
{
    public int Calculate(string s)
    {
        var result = 0;
        var stack = new Stack<int>();
        var operationSymbol = '+';
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

                if (operationSymbol == '+')
                {
                    stack.Push(temp);
                }

                if (operationSymbol == '-')
                {
                    stack.Push(-1 * temp);
                }

                if (operationSymbol == '*')
                {
                    var num1 = stack.Pop();
                    stack.Push(num1 * temp);
                }

                if (operationSymbol == '/')
                {
                    var num1 = stack.Pop();
                    stack.Push(num1 / temp);
                }

                index = i;
                continue;
            }

            if (s[index] == '+' || s[index] == '-' || s[index] == '*' || s[index] == '/')
            {
                operationSymbol = s[index];
            }

            index++;
        }

        while (stack.Count != 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}