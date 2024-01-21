namespace LeetCode.Solution0001_0050;

public class Solution0028
{
    public int StrStr_Ver1(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        for (var i = 0; i <= haystack.Length - needle.Length; i++)
        {
            var j = 0;
            for (j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    break;
                }
            }

            if (j == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }

    public int StrStr_Ver2(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }
        
        var lpsArray = GetLpsArray(needle);

        var i = 0;
        var j = 0;

        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            else if (j > 0)
            {
                j = lpsArray[j - 1];
            }
            else
            {
                i++;
            }

            if (j == needle.Length)
            {
                return i - j;
            }
        }

        return -1;
    }

    private int[] GetLpsArray(string needle)
    {
        var result = new int [needle.Length];

        var i = 1;
        var pre = 0;

        while (i < needle.Length)
        {
            if (needle[i] == needle[pre])
            {
                result[i] = pre + 1;
                pre++;
                i++;
            }
            else if (pre > 0)
            {
                pre = result[pre - 1];
            }
            else
            {
                i++;
            }
        }

        return result;
    }
}