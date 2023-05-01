namespace LeetCode.Solution0001_0050;

public class Solution0036
{
    public bool IsValidSudoku_Ver1(char[][] board)
    {
        for (var i = 0; i < board.Length; i++)
        {
            var used = new HashSet<char>();
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.' && !used.Add(board[i][j]))
                {
                    return false;
                }
            }
        }

        for (var j = 0; j < board[0].Length; j++)
        {
            var used = new HashSet<char>();
            for (var i = 0; i < board.Length; i++)
            {
                if (board[i][j] != '.' && !used.Add(board[i][j]))
                {
                    return false;
                }
            }
        }

        var xList = new List<int>() { 0, 0, 0, 1, 1, 1, -1, -1, -1 };
        var yList = new List<int>() { 0, 1, -1, 0, 1, -1, 0, 1, -1 };

        for (var i = 1; i < board.Length; i += 3)
        {
            for (var j = 1; j < board[i].Length; j += 3)
            {
                var used = new HashSet<char>();
                for (int k = 0; k < xList.Count; k++)
                {
                    var target = board[i + xList[k]][j + yList[k]];
                    if (target != '.' && !used.Add(target))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    public object IsValidSudoku_Ver2(char[][] board)
    {
        var shifts = new int[9][]
        {
            new int[] { -1, -1 },
            new int[] { -1, 0 },
            new int[] { -1, 1 },
            new int[] { 0, -1 },
            new int[] { 0, 0 },
            new int[] { 0, 1 },
            new int[] { 1, -1 },
            new int[] { 1, 0 },
            new int[] { 1, 1 }
        };

        for (var i = 0; i < board.Length; i++)
        {
            var array = new int [10];
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                if (array[board[i][j] - '0'] > 0)
                {
                    return false;
                }

                array[board[i][j] - '0']++;
            }
        }

        for (var j = 0; j < board[0].Length; j++)
        {
            var array = new int [10];
            for (var i = 0; i < board.Length; i++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                if (array[board[i][j] - '0'] > 0)
                {
                    return false;
                }

                array[board[i][j] - '0']++;
            }
        }

        for (var i = 1; i < board.Length; i += 3)
        {
            for (var j = 1; j < board[0].Length; j += 3)
            {
                var array = new int [10];
                for (var k = 0; k < shifts.Length; k++)
                {
                    var target = board[i + shifts[k][0]][j + shifts[k][1]];
                    if (target == '.')
                    {
                        continue;
                    }

                    if (array[target - '0'] > 0)
                    {
                        return false;
                    }

                    array[target - '0']++;
                }
            }
        }

        return true;
    }
}