namespace LeetCode.Solution0701_9999;

public class Solution0735
{
    public int[] AsteroidCollision_Ver1(int[] asteroids)
    {
        var stack = new Stack<int>();
        var index = 0;

        while (index < asteroids.Length)
        {
            if (asteroids[index] > 0)
            {
                stack.Push(asteroids[index]);
            }

            if (asteroids[index] < 0)
            {
                var explode = false;
                while (stack.Count > 0 && stack.Peek() > 0 && Math.Abs(stack.Peek()) <= Math.Abs(asteroids[index]))
                {
                    var pre = stack.Pop();
                    if (Math.Abs(pre) == Math.Abs(asteroids[index]))
                    {
                        explode = true;
                        break;
                    }
                }

                if (!explode && (stack.Count == 0 || stack.Peek() < 0))
                {
                    stack.Push(asteroids[index]);
                }
            }

            index++;
        }

        var array = stack.ToArray();
        Array.Reverse(array);

        return array;
    }

    public int[] AsteroidCollision_Ver2(int[] asteroids)
    {
        var list = new List<int>();
        var index = 0;

        while (index < asteroids.Length)
        {
            if (asteroids[index] > 0)
            {
                list.Add(asteroids[index]);
            }

            if (asteroids[index] < 0)
            {
                var vanished = false;
                while (list.Count > 0 && list.Last() > 0 && Math.Abs(list.Last()) <= Math.Abs(asteroids[index]))
                {
                    var pre = list.Last();
                    list.RemoveAt(list.Count - 1);
                    if (Math.Abs(pre) == Math.Abs(asteroids[index]))
                    {
                        vanished = true;
                        break;
                    }
                }

                if (!vanished && (list.Count == 0 || list.Last() < 0))
                {
                    list.Add(asteroids[index]);
                }
            }

            index++;
        }

        return list.ToArray();
    }
}