namespace LeetCode.Solution0301_0500;

public class Solution0383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var array = new int [26];

        for (var i = 0; i < magazine.Length; i++)
        {
            array[magazine[i] - 'a']++;
        }

        for (var i = 0; i < ransomNote.Length; i++)
        {
            array[ransomNote[i] - 'a']--;

            if (array[ransomNote[i] - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}