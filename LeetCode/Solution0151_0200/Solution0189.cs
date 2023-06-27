namespace LeetCode.Solution0151_0150;

public class Solution0189
{
    public void Rotate_Ver1(int[] nums, int k)
    {
        k %= nums.Length;

        var visited = nums.Length;
        var startIndex = 0;

        while (visited > 0)
        {
            var pos = startIndex;
            var nextPos = (pos + k) % nums.Length;
            var prev = nums[pos];

            do
            {
                (nums[nextPos], prev) = (prev, nums[nextPos]);
                visited--;
                
                pos = nextPos;
                nextPos = (pos + k) % nums.Length;
            } while (pos != startIndex);

            startIndex++;
        }
    }

    public void Rotate_Ver2(int[] nums, int k)
    {
        k %= nums.Length;

        var low = 0;
        var high = nums.Length - 1;
        while (low < high)
        {
            (nums[low], nums[high]) = (nums[high], nums[low]);
            low++;
            high--;
        }
            
        low = 0;
        high = k - 1;
        while (low < high)
        {
            (nums[low], nums[high]) = (nums[high], nums[low]);
            low++;
            high--;
        }
            
        low = k;
        high = nums.Length - 1;
        while (low < high)
        {
            (nums[low], nums[high]) = (nums[high], nums[low]);
            low++;
            high--;
        }
    }
}