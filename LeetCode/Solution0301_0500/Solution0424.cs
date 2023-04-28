namespace LeetCode.Solution0301_0500;

public class Solution0424
{
    public int CharacterReplacement(string s, int k)
    {
        var left = 0;
        var right = 0;
        var max = 0;
        var array = new int [26];

        while (right < s.Length)
        {
            array[s[right] - 'A']++;
            max = Math.Max(max, array[s[right] - 'A']);

            if (right - left + 1 > max + k)
            {
                array[s[left] - 'A']--;
                left++;
            }

            right++;
        }

        return s.Length - left;
    }
}