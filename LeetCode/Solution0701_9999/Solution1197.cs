namespace LeetCode.Solution0701_9999;

public class Solution1197
{
    public int MinKnightMoves(int x, int y)
    {
        var hashSet = new HashSet<string>();
        x = Math.Abs(x);
        y = Math.Abs(y);
        var result = 0;
        var queue = new Queue<int[]>();
        var directions = new int[][]
        {
            new[] { 2, 1 },
            new[] { 2, -1 },
            new[] { -2, 1 },
            new[] { -2, -1 },
            new[] { 1, 2 },
            new[] { 1, -2 },
            new[] { -1, 2 },
            new[] { -1, -2 },
        };

        queue.Enqueue(new[] { 0, 0 });
        hashSet.Add("0,0");

        while (queue.Count != 0)
        {
            var count = queue.Count;
            for (var cnt = 0; cnt < count; cnt++)
            {
                var current = queue.Dequeue();
                if (current[0] == x && current[1] == y)
                {
                    return result;
                }

                for (var i = 0; i < directions.Length; i++)
                {
                    var next = new int[] { current[0] + directions[i][0], current[1] + directions[i][1] };

                    if (next[0] < 0 || next[0] - x > 2 || next[1] < 0 || next[1] - y > 2
                        || hashSet.Contains($"{next[0]},{next[1]}"))
                    {
                        continue;
                    }

                    queue.Enqueue(next);
                    hashSet.Add($"{next[0]},{next[1]}");
                }
            }

            result++;
        }


        return result;
    }
}