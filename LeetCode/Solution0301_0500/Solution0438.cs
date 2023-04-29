namespace LeetCode.Solution0301_0500;

public class Solution0438
{
    public IList<int> FindAnagrams(string s, string p) {
        var array = new int [26];
        var notMatched = 0;
        var result = new List<int>();

        if(s.Length < p.Length)
        {
            return result;
        }

        for(var i = 0; i < p.Length; i++)
        {
            if(array[p[i] - 'a'] == 0)
            {
                notMatched++;
            }
            array[p[i] - 'a']++;

            array[s[i] - 'a']--;
            if(array[s[i] - 'a'] == 0)
            {
                notMatched--;
            }
        }

        if(notMatched == 0)
        {
            result.Add(0);
        }

        for(var i = p.Length; i < s.Length; i++)
        {
            array[s[i - p.Length] - 'a']++;
            if(array[s[i - p.Length] - 'a'] == 1)
            {
                notMatched++;
            }

            array[s[i] - 'a']--;
            if(array[s[i] - 'a'] == 0)
            {
                notMatched--;
            }
            
            if(notMatched == 0)
            {
                result.Add(i - p.Length + 1);
            }
        }

        return result;
    }
}