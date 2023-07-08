namespace LeetCode.Solution0001_0050;

public class Solution0046
{
    /// <summary>
    /// Backtrack
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute_Ver1(int[] nums)
    {
        var used = new bool [nums.Length];
        var result = new List<IList<int>>();

        Backtrack_Ver1(nums, used, new List<int>(), result);

        return result;
    }

    /// <summary>
    /// Backtrack - Swap
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute_Ver2(int[] nums)
    {
        var result = new List<IList<int>>();

        Backtrack_Ver2(nums, 0, result);

        return result;
    }

    /// <summary>
    /// Iteration
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Permute_Ver3(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>() { new List<int>() { nums[0] } };

        for (var i = 1; i < nums.Length; i++)
        {
            IList<IList<int>> stepResult = new List<IList<int>>();
            foreach (var item in result)
            {
                for (var index = 0; index <= item.Count; index++)
                {
                    var temp = new List<int>();
                    temp.AddRange(item);
                    temp.Insert(index, nums[i]);
                    stepResult.Add(temp);
                }
            }

            result = stepResult;
        }

        return result;
    }

    private void Backtrack_Ver1(int[] nums, bool[] used, List<int> curr, IList<IList<int>> result)
    {
        if (curr.Count == nums.Length)
        {
            result.Add(curr.ToArray());
            return;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (used[i])
            {
                continue;
            }

            curr.Add(nums[i]);
            used[i] = true;

            Backtrack_Ver1(nums, used, curr, result);

            curr.RemoveAt(curr.Count - 1);
            used[i] = false;
        }
    }

    private void Backtrack_Ver2(int[] nums, int index, IList<IList<int>> result)
    {
        if (index == nums.Length)
        {
            result.Add(new List<int>(nums));
            return;
        }

        for (var i = index; i < nums.Length; i++)
        {
            (nums[i], nums[index]) = (nums[index], nums[i]);

            Backtrack_Ver2(nums, index + 1, result);

            (nums[i], nums[index]) = (nums[index], nums[i]);
        }
    }
}