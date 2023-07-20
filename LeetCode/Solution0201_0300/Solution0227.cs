namespace LeetCode.Solution0201_0300;

public class Solution0227
{
    public int Calculate(string s)
    {
        var result = 0;
        var stack = new Stack<string>();
        var index = 0;

        while (index < s.Length)
        {
            if (s[index] == '+' || s[index] == '-' || s[index] == '*' || s[index] == '/')
            {
                stack.Push(s[index].ToString());
                index++;
                continue;
            }

            if (s[index] >= '0' && s[index] <= '9')
            {
                var i = index;
                while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                {
                    i++;
                }

                var temp = s.Substring(index, i - index);

                if (stack.Count == 0)
                {
                    stack.Push(temp);
                }
                else
                {
                    if (stack.Peek() == "+")
                    {
                        stack.Pop();
                        stack.Push(temp);
                    }
                    else if (stack.Peek() == "-")
                    {
                        stack.Pop();
                        stack.Push('-' + temp);
                    }
                    else if (stack.Peek() == "*")
                    {
                        var num2 = int.Parse(temp);
                        stack.Pop();
                        var num1 = int.Parse(stack.Pop());
                        stack.Push((num1 * num2).ToString());
                    }
                    else if (stack.Peek() == "/")
                    {
                        var num2 = int.Parse(temp);
                        stack.Pop();
                        var num1 = int.Parse(stack.Pop());
                        stack.Push((num1 / num2).ToString());
                    }
                    else
                    {
                        stack.Push(temp);
                    }
                }

                index = i;
                continue;
            }

            index++;
        }

        while (stack.Count != 0)
        {
            result += int.Parse(stack.Pop());
        }

        return result;
    }
}