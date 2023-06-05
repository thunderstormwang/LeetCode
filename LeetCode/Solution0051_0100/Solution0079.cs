namespace LeetCode.Solution0051_0100;

public class Solution0079
{
    private readonly int[][] _directions = new int[][]
    {
        new int[] { -1, 0 },
        new int[] { 1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 }
    };

    public bool Exist(char[][] board, string word)
    {
        var visited = new int [board.Length][];
        for (var i = 0; i < board.Length; i++)
        {
            visited[i] = new int [board[i].Length];
        }

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (DepthFirstSearch(board, i, j, word, 0, visited))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool DepthFirstSearch(char[][] board, int i, int j, string word, int index, int[][] visited)
    {
        if (index == word.Length)
        {
            return true;
        }

        if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || visited[i][j] == 1 || board[i][j] != word[index])
        {
            return false;
        }

        visited[i][j] = 1;

        for (var cnt = 0; cnt < _directions.Length; cnt++)
        {
            if (DepthFirstSearch(board, i + _directions[cnt][0], j + _directions[cnt][1], word, index + 1, visited))
            {
                return true;
            }
        }

        visited[i][j] = 0;

        return false;
    }
}