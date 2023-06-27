namespace LeetCode.Solution0701_9999;

public class Solution0739
{
    public int[] DailyTemperatures_Brutal(int[] temperatures)
    {
        var result = new int [temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++)
        {
            for (var j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[j] > temperatures[i])
                {
                    result[i] = j - i;
                    break;
                }
            }
        }

        return result;
    }

    public int[] DailyTemperatures_Stack(int[] temperatures)
    {
        var result = new int [temperatures.Length];
        var stack = new Stack<int>();

        stack.Push(0);

        for (var i = 1; i < temperatures.Length; i++)
        {
            while (stack.Count > 0)
            {
                var top = stack.Pop();

                if (temperatures[top] >= temperatures[i])
                {
                    stack.Push(top);
                    break;
                }

                result[top] = i - top;
            }

            stack.Push(i);
        }

        return result;
    }
}