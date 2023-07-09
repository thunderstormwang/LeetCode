using System.Text;

namespace LeetCode.Solution0051_0100;

public class Solution0051
{
    public IList<IList<string>> SolveNQueens_Ver1(int n)
    {
        var result = new List<IList<string>>();
        
        Backtrack_Ver1(n, new List<string>(), result);
        
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
    public IList<IList<string>> SolveNQueens_Ver2(int n)
    {
        var columns = new List<IList<int>>();
        Backtrack_Ver2(n, 0, new int [n], columns);

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

    private void Backtrack_Ver1(int n, IList<string> curr, IList<IList<string>> result)
    {
        if (curr.Count == n)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var j = 0; j < n; j++)
        {
            var row = curr.Count;
            if (!IsValid_Ver1(curr, row, j, n))
            {
                continue;
            }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append('.', n);
            stringBuilder.Replace('.', 'Q', j, 1);
            curr.Add(stringBuilder.ToString());
            
            Backtrack_Ver1(n, curr, result);
            
            curr.RemoveAt(curr.Count - 1);
        }
    }

    private bool IsValid_Ver1(IList<string> curr, int row, int candidateColumn, int n)
    {
        var i = 0;
        var j = 0;

        // 直線上不能有其它皇后
        for (i = row - 1; i >= 0; i--)
        {
            if (curr[i][candidateColumn] == 'Q')
            {
                return false;
            }
        }

        // 對角線上不能有其它皇后
        i = curr.Count - 1;
        j = candidateColumn - 1;
        while(i >= 0 && j >= 0)
        {
            if(curr[i][j] == 'Q')
            {
                return false;
            }

            i--;
            j--;
        }

        // 對角線上不能有其它皇后
        i = curr.Count - 1;
        j = candidateColumn + 1;
        while(i >= 0 && j < n)
        {
            if(curr[i][j] == 'Q')
            {
                return false;
            }

            i--;
            j++;
        }

        return true;
    }

    private void Backtrack_Ver2(int n, int index, int[] curr, IList<IList<int>> result)
    {
        if (index == n)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var j = 0; j < n; j++)
        {
            if (!IsValid_Ver2(index, j, curr))
            {
                continue;
            }

            curr[index] = j;
            Backtrack_Ver2(n, index + 1, curr, result);
            curr[index] = 0;
        }
    }

    private bool IsValid_Ver2(int row, int column, int[] curr)
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
}