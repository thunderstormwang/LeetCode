namespace LeetCode.Solution0701_9999;

public class Solution0763
{
    public IList<int> PartitionLabels(string s)
    {
        var result = new List<int>();
        var rightMostIndex = new int [26];
        for (var i = s.Length - 1; i >= 0; i--)
        {
            rightMostIndex[s[i] - 'a'] = Math.Max(rightMostIndex[s[i] - 'a'], i);
        }

        var tempStart = 0;
        var tempEnd = 0;
        for (var i = 0; i < s.Length; i++)
        {
            tempEnd = Math.Max(tempEnd, rightMostIndex[s[i] - 'a']);
            if (i == tempEnd)
            {
                result.Add(tempEnd - tempStart + 1);
                tempStart = i + 1;
                tempEnd = i + 1;
            }
        }

        return result;
    }
}