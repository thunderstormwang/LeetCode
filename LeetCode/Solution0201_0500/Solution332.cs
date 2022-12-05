namespace LeetCode.Solution0201_0500;

public class Solution332
{
    private List<IList<string>> _tickets;
    private bool[] _used;

    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        _used = new bool[tickets.Count];

        // 排序
        _tickets = tickets.ToList();
        _tickets.Sort((x, y) => string.Compare(x[0], y[0]) != 0 ? string.Compare(x[0], y[0]) : string.Compare(x[1], y[1]));

        var backtrackResult = new List<IList<string>>();
        backtrackResult.Add(new List<string>() { "JFK", "JFK" });
        Backtrack(backtrackResult);

        var result = backtrackResult.Select(b => b[1]).ToList();
        return result;
    }

    private bool Backtrack(IList<IList<string>> result)
    {
        if (result.Count == _tickets.Count + 1)
        {
            return true;
        }

        for (var i = 0; i < _tickets.Count; i++)
        {
            if (_tickets[i][0] == result.Last()[1] && !_used[i])
            {
                result.Add(_tickets[i]);
                _used[i] = true;
                if (Backtrack(result))
                {
                    return true;
                }

                result.RemoveAt(result.Count - 1);
                _used[i] = false;
            }
        }

        return false;
    }
}