namespace LeetCode.Solution0051_0100;

public class Solution0078
{
    public IList<IList<int>> Subsets_Ver1(int[] nums)
    {
        var result = new List<IList<int>>();

        Backtrack_Ver1(nums, 0, new List<int>(), result);

        return result;
    }

    public IList<IList<int>> Subsets_Ver2(int[] nums)
    {
        var result = new List<IList<int>>();
        
        Backtrack_Ver2(nums, 0, new List<int>(), result);

        return result;
    }

    private void Backtrack_Ver1(int[] nums, int index, IList<int> curr, IList<IList<int>> result)
    {
        if (index == nums.Length)
        {
            result.Add(curr.ToArray());
            return;
        }

        Backtrack_Ver1(nums, index + 1, curr, result);

        curr.Add(nums[index]);
        Backtrack_Ver1(nums, index + 1, curr, result);
        curr.RemoveAt(curr.Count - 1);
    }

    private void Backtrack_Ver2(int[] nums, int index, IList<int> curr, IList<IList<int>> result)
    {
        result.Add(curr.ToArray());

        for (var i = index; i < nums.Length; i++)
        {
            curr.Add(nums[i]);
            Backtrack_Ver2(nums, i + 1, curr, result);
            curr.Remove(nums[i]);
        }
    }
}