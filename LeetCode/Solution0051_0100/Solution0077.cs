namespace LeetCode.Solution0051_0100;

public class Solution0077
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var array = Enumerable.Range(1, n).ToArray();

        var result = new List<IList<int>>();
        Backtrack(array, k, 0, new List<int>(), result);

        return result;
    }

    private void Backtrack(int[] array, int k, int index, List<int> curr, List<IList<int>> result)
    {
        if (curr.Count == k)
        {
            result.Add(curr.ToArray());
            return;
        }

        // 剩餘元素不夠使用, 立即結束
        if ((array.Length - index) < k - curr.Count)
        {
            return;
        }

        for (var i = index; i < array.Length; i++)
        {
            curr.Add(array[i]);
            Backtrack(array, k, i + 1, curr, result);
            curr.Remove(array[i]);
        }
    }
}