namespace LeetCode.Solution0501_0700;

public class Solution0543
{
    public int[][] UpdateMatrix_Ver1(int[][] mat)
    {
        var queue = new Queue<int[]>();
        var directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };

        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue(new int[] { i, j, 0 });
                }
                else
                {
                    mat[i][j] = int.MaxValue;
                }
            }
        }

        while (queue.Count != 0)
        {
            var pos = queue.Dequeue();
            if (pos[0] < 0 || pos[0] > mat.Length - 1 || pos[1] < 0 || pos[1] > mat[0].Length - 1
                || pos[2] > mat[pos[0]][pos[1]])
            {
                continue;
            }

            mat[pos[0]][pos[1]] = pos[2];
            for (var i = 0; i < directions.Length; i++)
            {
                queue.Enqueue(new int[] { pos[0] + directions[i][0], pos[1] + directions[i][1], pos[2] + 1 });
            }
        }

        return mat;
    }

    public int[][] UpdateMatrix_Ver2(int[][] mat)
    {
        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] != 0)
                {
                    mat[i][j] = int.MaxValue - 1;
                }
            }
        }

        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[i].Length; j++)
            {
                if (i < mat.Length - 1)
                {
                    mat[i + 1][j] = Math.Min(mat[i][j] + 1, mat[i + 1][j]);
                }

                if (j < mat[i].Length - 1)
                {
                    mat[i][j + 1] = Math.Min(mat[i][j] + 1, mat[i][j + 1]);
                }
            }
        }

        for (var i = mat.Length - 1; i >= 0; i--)
        {
            for (var j = mat[i].Length - 1; j >= 0; j--)
            {
                if (i > 0)
                {
                    mat[i - 1][j] = Math.Min(mat[i][j] + 1, mat[i - 1][j]);
                }

                if (j > 0)
                {
                    mat[i][j - 1] = Math.Min(mat[i][j] + 1, mat[i][j - 1]);
                }
            }
        }

        return mat;
    }
}