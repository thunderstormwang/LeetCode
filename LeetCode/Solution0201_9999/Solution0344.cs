namespace LeetCode.Solution0201_9999
{
    public class Solution0344
    {
        public void ReverseString(char[] s)
        {
            var low = 0;
            var high = s.Length - 1;

            while (low < high)
            {
                (s[low], s[high]) = (s[high], s[low]);

                low++;
                high--;
            }
        }
        
        // Time: O(N)
        // Space: O(1)
    }
}