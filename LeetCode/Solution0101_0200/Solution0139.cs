namespace LeetCode.Solution0101_0200;

public class Solution0139
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 1];

        dp[0] = true;

        for (var j = 1; j < s.Length + 1; j++)
        {
            for (var i = 0; i < wordDict.Count; i++)
            {
                var startIndex = j - wordDict[i].Length;

                if (startIndex < 0)
                {
                    continue;
                }

                if (!dp[startIndex])
                {
                    continue;
                }

                var subStr = s.Substring(startIndex, wordDict[i].Length);
                if (subStr == wordDict[i])
                {
                    dp[j] = true;
                }
            }
        }

        return dp[s.Length];
    }
}