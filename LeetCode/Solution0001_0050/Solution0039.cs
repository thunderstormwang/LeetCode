namespace LeetCode.Solution0001_0050;

public class Solution0039
{
    private int[] _candidates;

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        _candidates = candidates;
            
        var result = new List<IList<int>>();
        Backtrack(target, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int target, int startIndex, IList<int> curr, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(curr.ToArray());
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (var i = startIndex; i < _candidates.Length; i++)
        {
            curr.Add(_candidates[i]);
            Backtrack(target - _candidates[i], i, curr, result);
            curr.Remove(_candidates[i]);
        }
    }
}