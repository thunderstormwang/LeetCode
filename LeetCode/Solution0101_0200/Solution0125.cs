namespace LeetCode.Solution0101_0200;

public class Solution0125
{
    public bool IsPalindrome_Ver1(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while ((s[left] < 'a' || s[left] > 'z') 
                   && (s[left] < 'A' || s[left] > 'Z') 
                   && (s[left] < '0' || s[left] > '9') 
                   && left < right)
            {
                left++;
            }

            while ((s[right] < 'a' || s[right] > 'z') 
                   && (s[right] < 'A' || s[right] > 'Z') 
                   && (s[right] < '0' || s[right] > '9') 
                   && right > left)
            {
                right--;
            }

            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public bool IsPalindrome_Ver2(string s)
    {
        s = s.ToLower();

        var left = 0;
        var right = s.Length - 1;

        while (right > left)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}