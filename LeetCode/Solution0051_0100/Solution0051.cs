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

    /// <summary>
    /// 以一維陣列記錄 column 的位置, 只記 column 是因為陣列的位置就足以代表 row
    /// <br/>ex: 第 i 個皇后放的行列位置可記作 i, array[i]
    /// <br/>
    /// <br/>
    /// 以複雜度的計算來看, 這樣沒有比較快
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<IList<string>> SolveNQueens_1Dim(int n)
    {
        _n = n;
        var columns = new List<IList<int>>();
        Backtrack_1Dim(0, new int [n], columns);

        var result = new List<IList<string>>();
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

        // 直線上不能有其它皇后
        for (i = row - 1; i >= 0; i--)
        {
            if (curr[i][column] == 'Q')
            {
                return false;
            }
        }

        // 對角線上不能有其它皇后
        for (i = row - 1, j = column - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (curr[i][j] == 'Q')
            {
                return false;
            }
        }

        // 對角線上不能有其它皇后
        for (i = row - 1, j = column + 1; i >= 0 && j < _n; i--, j++)
        {
            if (curr[i][j] == 'Q')
            {
                return false;
            }
        }

        return true;
    }

    private void Backtrack_1Dim(int index, int[] curr, IList<IList<int>> result)
    {
        if (index == _n)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var j = 0; j < _n; j++)
        {
            if (!IsValid_1Dim(index, j, curr))
            {
                continue;
            }

            curr[index] = j;
            Backtrack_1Dim(index + 1, curr, result);
            curr[index] = 0;
        }
    }

    private bool IsValid_1Dim(int row, int column, int[] curr)
    {
        for (var i = row - 1; i >= 0; i--)
        {
            // 直線上不能有其它皇后
            if (curr[i] == column)
            {
                return false;
            }

            // 對角線上不能有其它皇后
            if (Math.Abs(row - i) == Math.Abs(column - curr[i]))
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