namespace LeetCode.Solution0701_9999;

public class Solution0739
{
    /// <summary>
    /// Brutal Force
    /// </summary>
    /// <param name="temperatures"></param>
    /// <returns></returns>
    public int[] DailyTemperatures_Ver1(int[] temperatures)
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

    /// <summary>
    /// Monotonic Stack
    /// </summary>
    /// <param name="temperatures"></param>
    /// <returns></returns>
    public int[] DailyTemperatures_Ver2(int[] temperatures)
    {
        var result = new int [temperatures.Length];
        var stack = new Stack<int>();

        for (var i = 0; i < temperatures.Length; i++)
        {
            if (stack.Count == 0 || temperatures[stack.Peek()] >= temperatures[i])
            {
                stack.Push(i);
                continue;
            }

            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                var curr = stack.Pop();
                result[curr] = i - curr;
            }

            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            result[curr] = 0;
        }

        return result;
    }
}