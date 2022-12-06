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

        var result = new List<string>();
        result.Add("JFK");
        Backtrack(result);

        return result;
    }

    private bool Backtrack(IList<string> result)
    {
        if (result.Count == _tickets.Count + 1)
        {
            return true;
        }

        for (var i = 0; i < _tickets.Count; i++)
        {
            if (_tickets[i][0] != result.Last() || _used[i])
            {
                continue;
            }
            
            result.Add(_tickets[i][1]);
            _used[i] = true;
            if (Backtrack(result))
            {
                return true;
            }

            result.RemoveAt(result.Count - 1);
            _used[i] = false;
        }

        return false;
    }
}