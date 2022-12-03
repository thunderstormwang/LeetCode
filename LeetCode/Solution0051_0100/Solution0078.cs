namespace LeetCode.Solution0051_0100;

public class Solution0078
{
    private int[] _nums;

    public IList<IList<int>> Subsets_WithEndCondition(int[] nums)
    {
        _nums = nums;

        var result = new List<IList<int>>();
        Backtrack_WithEndCondition(0, new List<int>(), result);
        return result;
    }

    public IList<IList<int>> Subsets_NoEndCondtion(int[] nums)
    {
        _nums = nums;
        
        var result = new List<IList<int>>();
        Backtrack__NoEndCondition(0, new List<int>(), result);

        return result;
    }

    private void Backtrack_WithEndCondition(int index, List<int> curr, IList<IList<int>> result)
    {
        if (index == _nums.Length)
        {
            result.Add(curr.ToArray());
            return;
        }

        Backtrack_WithEndCondition(index + 1, curr, result);

        curr.Add(_nums[index]);
        Backtrack_WithEndCondition(index + 1, curr, result);
        curr.RemoveAt(curr.Count - 1);
    }

    private void Backtrack__NoEndCondition(int index, IList<int> curr, IList<IList<int>> result)
    {
        result.Add(curr.ToArray());

        for (var i = index; i < _nums.Length; i++)
        {
            curr.Add(_nums[i]);
            Backtrack__NoEndCondition(i + 1, curr, result);
            curr.Remove(_nums[i]);
        }
    }
    
    // Time: O(2^N) -- 每個元素可選或不選
    // Time: O(N) -- 最多遞迴 N 層
}