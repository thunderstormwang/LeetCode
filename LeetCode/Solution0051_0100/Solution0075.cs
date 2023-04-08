namespace LeetCode.Solution0051_0100;

public class Solution0075
{
    public void SortColors(int[] nums)
    {
        var redPointer = 0;
        var bluePointer = nums.Length - 1;
        
        for (var i = 0; i <= bluePointer; i++)
        {
            if (nums[i] == 0)
            {
                (nums[redPointer], nums[i]) = (nums[i], nums[redPointer]);
                redPointer++;
            }
            else if (nums[i] == 2)
            {
                (nums[bluePointer], nums[i]) = (nums[i], nums[bluePointer]);
                bluePointer--;
                i--;
            }
        }
    }
}