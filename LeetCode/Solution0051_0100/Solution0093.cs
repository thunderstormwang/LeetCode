namespace LeetCode.Solution0051_0100;

public class Solution0093
{
    private string _s;

    public IList<string> RestoreIpAddresses(string s)
    {
        _s = s;

        var result = new List<string>();
        Backtrack(0, new List<string>(), result);
        return result;
    }

    private void Backtrack(int index, IList<string> curr, IList<string> result)
    {
        if (curr.Count == 4 && index == _s.Length)
        {
            result.Add(string.Join(".", curr));
            return;
        }

        for (var i = index; i < _s.Length && i - index <= 2; i++)
        {
            var subStr = _s.Substring(index, i - index + 1);
            if (!IsValidIp(subStr))
            {
                continue;
            }

            curr.Add(subStr);
            Backtrack(i + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }

    private bool IsValidIp(string input)
    {
        if (input.Length >= 2 && input[0] == '0')
        {
            return false;
        }

        if (!int.TryParse(input, out var parseIp))
        {
            return false;
        }

        if (parseIp > 255)
        {
            return false;
        }

        return true;
    }
    
    // Time: O(3^4) -- 因為迴圈最多只跑 3 個元素, 然後遞迴最多跑四層
    // 如果迴圈不做跑 3 個元素就停止的話, 因為字串長度最多 20, 那就有 19 個分割點, 那一共有 C(19,3) 種組合
    // Time: O(1) -- 最多遞迴 4 個
}