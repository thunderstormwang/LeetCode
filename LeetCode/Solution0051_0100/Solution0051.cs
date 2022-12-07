using System.Text;

namespace LeetCode.Solution0051_0100;

public class Solution0051
{
    private int _n;

    public IList<IList<string>> SolveNQueens(int n)
    {
        _n = n;

        var result = new List<IList<string>>();
        Backtrack(new List<string>(), result);
        return result;
    }

    private void Backtrack(List<string> curr, List<IList<string>> result)
    {
        if (curr.Count == _n)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var j = 0; j < _n; j++)
        {
            var row = curr.Count;
            if (!IsValid(row, j, curr))
            {
                continue;
            }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append('.', _n);
            stringBuilder.Replace('.', 'Q', j, 1);
            curr.Add(stringBuilder.ToString());
            Backtrack(curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }

    private bool IsValid(int row, int column, List<string> curr)
    {
        var i = 0;
        var j = 0;
            
        // 看直線有沒有其它皇后
        for (i = row - 1; i >= 0; i--)
        {
            if (curr[i][column] == 'Q')
            {
                return false;
            }
        }

        // 看對角線有沒有其它皇后
        for (i = row - 1, j = column - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (curr[i][j] == 'Q')
            {
                return false;
            }
        }
            
        // 看對角線有沒有其它皇后
        for (i = row - 1, j = column + 1; i >= 0 && j < _n; i--, j++)
        {
            if (curr[i][j] == 'Q')
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// 以複雜度的計算來看, 這樣沒有比較快
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<IList<string>> SolveNQueens_1Dim(int n)
    {
        IList<IList<int>> columns = new List<IList<int>>();
        Backtrack_1Dim(n, 0, new int [n], columns);
    
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var item in columns)
        {
            var temp = new List<string>();
            foreach (var element in item)
            {
                var str = new StringBuilder(new String('.', n))
                {
                    [element] = 'Q'
                };
                temp.Add(str.ToString());
            }
    
            result.Add(temp);
        }
    
        return result;
    }
    
    private void Backtrack_1Dim(int n, int index, int[] columns, IList<IList<int>> result)
    {
        if (index == n)
        {
            result.Add(columns.ToArray());
            return;
        }
    
        for (var i = 0; i < n; i++)
        {
            columns[index] = i;
            if (!IsValid_1Dim(columns, index))
            {
                continue;
            }
    
            Backtrack_1Dim(n, index + 1, columns, result);
        }
    }
    
    private bool IsValid_1Dim(int[] curr, int index)
    {
        for (var i = 0; i < index; i++)
        {
            // 不能在同一個 column, 也不能在對角線
            if (curr[i] == curr[index] ||
                Math.Abs(index - i) == Math.Abs(curr[index] - curr[i]))
            {
                return false;
            }
        }
    
        return true;
    }

    // Time: O(N!) -- 第一個皇后有 N 個位置可選, 第二個皇后有 N-1 個位置可選 ... 最後一個皇后有 1 個位置可選
    // 所以有 N!
    // Space: O(N) -- 最多遞迴 N 層
}