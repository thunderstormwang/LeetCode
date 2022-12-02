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
    
    // Time: O(C(N-1,3)) = O(N^3) -- N-1 個地方選 3 個 . 去分隔
    // Time: O(1) -- 最多遞迴 4 個
}