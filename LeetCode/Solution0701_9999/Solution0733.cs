namespace LeetCode.Solution0701_9999;

public class Solution0733
{
    public int[][] FloodFill_BFS(int[][] image, int sr, int sc, int color)
    {
        var queue = new Queue<int[]>();
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };

        var oriColor = image[sr][sc];
        if (image[sr][sc] != color)
        {
            queue.Enqueue(new int[] { sr, sc });
        }

        while (queue.Count != 0)
        {
            var pos = queue.Dequeue();

            if (image[pos[0]][pos[1]] != oriColor)
            {
                continue;
            }
            
            image[pos[0]][pos[1]] = color;

            for (var i = 0; i < directions.Length; i++)
            {
                var newPos = new int[] { pos[0] + directions[i][0], pos[1] + directions[i][1] };
                if (newPos[0] < 0 || newPos[0] >= image.Length || newPos[1] < 0 || newPos[1] >= image[0].Length)
                {
                    continue;
                }

                queue.Enqueue(newPos);
            }
        }

        return image;
    }

    public int[][] FloodFill_DFS(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] != color)
        {
            Recursive(image, sr, sc, color, image[sr][sc]);
        }

        return image;
    }

    private void Recursive(int[][] image, int sr, int sc, int color, int oriColor)
    {
        if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length)
        {
            return;
        }

        if (image[sr][sc] != oriColor)
        {
            return;
        }

        image[sr][sc] = color;
        Recursive(image, sr - 1, sc, color, oriColor);
        Recursive(image, sr + 1, sc, color, oriColor);
        Recursive(image, sr, sc - 1, color, oriColor);
        Recursive(image, sr, sc + 1, color, oriColor);
    }
}