namespace LeetCode.Solution0001_0050;

public class Solution0037
{
    private int _number = 9;
    private HashSet<char>[] _rowSet = new HashSet<char>[9];
    private HashSet<char>[] _columnSet = new HashSet<char>[9];

    public void SolveSudoku(char[][] board)
    {
        for (var i = 0; i < _number; i++)
        {
            _rowSet[i] = new HashSet<char>();
            _columnSet[i] = new HashSet<char>();
        }

        for (var i = 0; i < _number; i++)
        {
            for (var j = 0; j < _number; j++)
            {
                if (board[i][j] != '.')
                {
                    _rowSet[i].Add(board[i][j]);
                    _columnSet[j].Add(board[i][j]);
                }
            }
        }

        Backtrack(0, 0, board);
    }

    private bool Backtrack(int row, int column, char[][] board)
    {
        if (row == _number && column == 0)
        {
            return CheckSubBox(board);
        }

        var nextRow = row;
        var nextColumn = column + 1;
        if (nextColumn == _number)
        {
            nextRow++;
            nextColumn = 0;
        }

        if (board[row][column] != '.')
        {
            return Backtrack(nextRow, nextColumn, board);
        }

        for (var i = 1; i <= _number; i++)
        {
            var c = i.ToString()[0];

            if (_rowSet[row].Contains(c) || _columnSet[column].Contains(c))
            {
                continue;
            }

            board[row][column] = c;
            _rowSet[row].Add(c);
            _columnSet[column].Add(c);

            if (Backtrack(nextRow, nextColumn, board))
            {
                return true;
            }

            board[row][column] = '.';
            _rowSet[row].Remove(c);
            _columnSet[column].Remove(c);
        }

        return false;
    }

    private bool CheckSubBox(char[][] borad)
    {
        var subBoxIndexes = new List<(int R, int C)>
        {
            (-1, -1), (-1, 0), (-1, 1),
            (0, -1), (0, 0), (0, 1),
            (1, -1), (1, 0), (1, 1),
        };

        for (var i = 1; i < _number; i += 3)
        {
            for (var j = 1; j < _number; j += 3)
            {
                var hashSet = new HashSet<char>();
                foreach (var item in subBoxIndexes)
                {
                    if (hashSet.Contains(borad[i + item.R][j + item.C]))
                    {
                        return false;
                    }

                    hashSet.Add(borad[i + item.R][j + item.C]);
                }
            }
        }

        return true;
    }
}