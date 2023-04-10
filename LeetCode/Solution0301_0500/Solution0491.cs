namespace LeetCode.Solution0301_0500;

public class Solution0491
{
    private int[] _nums;
        
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        _nums = nums;
            
        var result = new List<IList<int>>();
        Backtrack(0, new List<int>(), result);

        return result;
    }
        
    private void Backtrack(int index, IList<int> curr, IList<IList<int>> result)
    {
        if (curr.Count >= 2)
        {
            result.Add(curr.ToArray());
        }

        var used = new HashSet<int>();
            
        for (var i = index; i < _nums.Length; i++)
        {
            if (used.Contains(_nums[i]))
            {
                continue;
            }

            if (curr.Count != 0 && curr.Last() > _nums[i])
            {
                continue;
            }

            curr.Add(_nums[i]);
            Backtrack(i + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
            used.Add(_nums[i]);
        }
    }
}