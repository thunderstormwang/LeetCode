namespace LeetCode.Solution0001_0050;

public class Solution0040
{
    private int[] _candidates;
        
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        _candidates = candidates;
        Array.Sort(candidates);
            
        var result = new List<IList<int>>();
        FindCombinationSum(target, 0, new List<int>(), result);
        return result;
    }

    private void FindCombinationSum(int target, int startIndex, IList<int> curr, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var i = startIndex; i < _candidates.Length && _candidates[i] <= target; i++)
        {
            if (i > startIndex && _candidates[i] == _candidates[i - 1])
            {
                continue;
            }

            curr.Add(_candidates[i]);
            FindCombinationSum(target - _candidates[i], i + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}