namespace LeetCode.Solution0501_9999;

public class Solution0763
{
    public IList<int> PartitionLabels(string s)
    {
        var result = new List<int>();
        var rightMostDict = new Dictionary<char, int>();
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (!rightMostDict.ContainsKey(s[i]))
            {
                rightMostDict.Add(s[i], i);
            }
        }

        var tempStart = 0;
        var tempEnd = 0;
        for (var i = 0; i < s.Length; i++)
        {
            tempEnd = Math.Max(tempEnd, rightMostDict[s[i]]);
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