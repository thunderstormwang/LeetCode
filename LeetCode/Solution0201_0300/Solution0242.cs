namespace LeetCode.Solution0201_0300;

public class Solution0242
{
    public bool IsAnagram(string s, string t)
    {
        var array = new int[26];

        for(var i = 0; i < s.Length; i++)
        {
            array[s[i] - 'a']++;
        }

        for(var i = 0; i < t.Length; i++)
        {
            array[t[i] - 'a']--;
        }

        for(var i = 0; i < array.Length; i++)
        {
            if(array[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}