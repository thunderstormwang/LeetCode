namespace LeetCode.Solution0001_0050;

public class Solution0037
{
    private int _number = 9;
    private HashSet<char>[] _rowSet = new HashSet<char>[9];
    private HashSet<char>[] _columnSet = new HashSet<char>[9];

    private HashSet<char>[][] _subBoxSet = new HashSet<char>[3][]
    {
        new HashSet<char>[3] { new HashSet<char>(), new HashSet<char>(), new HashSet<char>() },
        new HashSet<char>[3] { new HashSet<char>(), new HashSet<char>(), new HashSet<char>() },
        new HashSet<char>[3] { new HashSet<char>(), new HashSet<char>(), new HashSet<char>() }
    };

    public void SolveSudoku_Ver1(char[][] board)
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
                    _subBoxSet[i / 3][j / 3].Add(board[i][j]);
                }
            }
        }

        Backtrack_Ver1(0, 0, board);
    }

    private bool Backtrack_Ver1(int row, int column, char[][] board)
    {
        if (row == _number && column == 0)
        {
            return true;
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
            return Backtrack_Ver1(nextRow, nextColumn, board);
        }

        for (var i = 1; i <= _number; i++)
        {
            var candidate = i.ToString()[0];

            if (_rowSet[row].Contains(candidate) || _columnSet[column].Contains(candidate) || _subBoxSet[row / 3][column / 3].Contains(candidate))
            {
                continue;
            }

            board[row][column] = candidate;
            _rowSet[row].Add(candidate);
            _columnSet[column].Add(candidate);
            _subBoxSet[row / 3][column / 3].Add(candidate);

            if (Backtrack_Ver1(nextRow, nextColumn, board))
            {
                return true;
            }

            board[row][column] = '.';
            _rowSet[row].Remove(candidate);
            _columnSet[column].Remove(candidate);
            _subBoxSet[row / 3][column / 3].Remove(candidate);
        }

        return false;
    }

    public void SolveSudoku_Ver2(char[][] board)
    {
        Backtrack_Ver2(board, 0, 0);
    }

    private bool Backtrack_Ver2(char[][] board, int i, int j)
    {
        if (i == _number && j == 0)
        {
            return true;
        }

        var addRow = (j + 1) % _number == 0 ? 1 : 0;
        var nextRow = i + addRow;
        var nextColumn = (j + 1) % _number;

        if (board[i][j] != '.')
        {
            return Backtrack_Ver2(board, nextRow, nextColumn);
        }

        var number = 1;
        while (number <= 9)
        {
            var candidate = number.ToString()[0];
            if (CheckCandidate(board, i, j, candidate))
            {
                if (Backtrack_Ver2(board, nextRow, nextColumn))
                {
                    return true;
                }
            }

            number++;
        }

        board[i][j] = '.';

        return false;
    }

    private bool CheckCandidate(char[][] board, int row, int column, char candidate)
    {
        for (var j = 0; j < _number; j++)
        {
            if (board[row][j] == candidate)
            {
                return false;
            }
        }

        for (var i = 0; i < _number; i++)
        {
            if (board[i][column] == candidate)
            {
                return false;
            }
        }
        
        var blockTopLeftRow = row / 3 * 3;
        var blockTopLeftColumn = column / 3 * 3;
        
        for(var i = blockTopLeftRow; i < blockTopLeftRow + 3; i++)
        {
            for(var j = blockTopLeftColumn; j < blockTopLeftColumn + 3; j++)
            {
                if(board[i][j] == candidate)
                {
                    return false;
                }
            }
        }

        return true;
    }
}