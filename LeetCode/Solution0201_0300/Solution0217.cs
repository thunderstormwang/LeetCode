namespace LeetCode.Solution0201_0300;

public class Solution0217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var item in nums)
        {
            if (!hashSet.Add(item))
            {
                return true;
            }
        }

        return false;
    }
}