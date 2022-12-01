namespace LeetCode.Solution0101_0200;

public class Solution0131
{
    private string _input;

    public IList<IList<string>> Partition_IndexAndLength(string s)
    {
        _input = s;

        var result = new List<IList<string>>();
        Backtrack_IndexAndLength(0, new List<string>(), result);
        return result;
    }

    private void Backtrack_IndexAndLength(int index, List<string> curr, List<IList<string>> result)
    {
        if (index > _input.Length - 1)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var length = 1; index + length <= _input.Length; length++)
        {
            var subStr = _input.Substring(index, length);
            if (!IsPalindrome(subStr))
            {
                continue;
            }

            curr.Add(subStr);
            Backtrack_IndexAndLength(index + length, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }

    public IList<IList<string>> Partition_Index(string s)
    {
        _input = s;

        var result = new List<IList<string>>();
        Backtrack_Index(0, new List<string>(), result);
        return result;
    }

    private void Backtrack_Index(int index, List<string> curr, List<IList<string>> result)
    {
        if (index > _input.Length - 1)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var endIndex = index; endIndex < _input.Length; endIndex++)
        {
            var subStr = _input.Substring(index, endIndex - index + 1);
            if (!IsPalindrome(subStr))
            {
                continue;
            }

            curr.Add(subStr);
            Backtrack_IndexAndLength(endIndex + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }

    private bool IsPalindrome(string input)
    {
        var start = 0;
        var end = input.Length - 1;

        while (start <= end)
        {
            if (input[start++] != input[end--])
            {
                return false;
            }
        }

        return true;
    }
    
    // Time: O(2^N) -- N 個字元有 N-1 個逗點，所以子字串的切法有 2^(N-1) 種，每種組合都要跑過
    // Space: O(N) -- 遞迴最多走到 N 層
}