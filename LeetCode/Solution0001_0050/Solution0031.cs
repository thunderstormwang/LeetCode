namespace LeetCode.Solution0001_0050;

public class Solution0031
{
    public void NextPermutation_Ver1(int[] nums)
    {
        var lastIncrIndex = -1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                continue;
            }

            lastIncrIndex = i;
        }

        if (lastIncrIndex != -1)
        {
            var targetIndex = lastIncrIndex - 1;
            var candidateIndex = lastIncrIndex;

            for (var i = lastIncrIndex; i < nums.Length; i++)
            {
                if (nums[i] <= nums[targetIndex])
                {
                    continue;
                }

                candidateIndex = i;
            }

            var temp = nums[candidateIndex];
            nums[candidateIndex] = nums[targetIndex];
            nums[targetIndex] = temp;
        }

        var startIndex = lastIncrIndex == -1 ? 0 : lastIncrIndex;
        var endIndex = nums.Length - 1;

        while (startIndex < endIndex)
        {
            var temp = nums[startIndex];
            nums[startIndex] = nums[endIndex];
            nums[endIndex] = temp;

            startIndex++;
            endIndex--;
        }
    }

    public void NextPermutation_Ver2(int[] nums)
    {
        var decreasingIndex = -1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] >= nums[i + 1])
            {
                continue;
            }

            decreasingIndex = i;
            break;
        }

        if (decreasingIndex != -1)
        {
            var justLargerIndex = 0;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] <= nums[decreasingIndex])
                {
                    continue;
                }

                justLargerIndex = i;
                break;
            }

            (nums[decreasingIndex], nums[justLargerIndex]) = (nums[justLargerIndex], nums[decreasingIndex]);
        }

        var startIndex = decreasingIndex + 1;
        var endIndex = nums.Length - 1;
        while (startIndex < endIndex)
        {
            (nums[startIndex], nums[endIndex]) = (nums[endIndex], nums[startIndex]);
            startIndex++;
            endIndex--;
        }
    }
}