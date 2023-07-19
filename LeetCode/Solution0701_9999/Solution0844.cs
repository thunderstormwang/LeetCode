using System.Text;

namespace LeetCode.Solution0701_9999;

public class Solution0844
{
    public bool BackspaceCompare_Ver1(string s, string t)
    {
        var sBuilder1 = new StringBuilder();
        var sBuilder2 = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                if (sBuilder1.Length > 0)
                {
                    sBuilder1.Remove(sBuilder1.Length - 1, 1);
                }

                continue;
            }

            sBuilder1.Append(s[i]);
        }

        for (var i = 0; i < t.Length; i++)
        {
            if (t[i] == '#')
            {
                if (sBuilder2.Length > 0)
                {
                    sBuilder2.Remove(sBuilder2.Length - 1, 1);
                }

                continue;
            }

            sBuilder2.Append(t[i]);
        }

        return sBuilder1.ToString() == sBuilder2.ToString();
    }

    public bool BackspaceCompare_Ver2(string s, string t)
    {
        var pointer1 = s.Length - 1;
        var pointer2 = t.Length - 1;

        while (pointer1 >= 0 || pointer2 >= 0)
        {
            var count = 0;
            while (pointer1 >= 0 && (s[pointer1] == '#' || count > 0))
            {
                if (s[pointer1] == '#')
                {
                    pointer1--;
                    count++;
                }
                else
                {
                    pointer1--;
                    count--;
                }
            }

            count = 0;
            while (pointer2 >= 0 && (t[pointer2] == '#' || count > 0))
            {
                if (t[pointer2] == '#')
                {
                    pointer2--;
                    count++;
                }
                else
                {
                    pointer2--;
                    count--;
                }
            }

            if (pointer1 == -1 && pointer2 == -1)
            {
                return true;
            }

            if (pointer1 == -1 || pointer2 == -1 || s[pointer1] != t[pointer2])
            {
                return false;
            }

            pointer1--;
            pointer2--;
        }

        return true;
    }
}