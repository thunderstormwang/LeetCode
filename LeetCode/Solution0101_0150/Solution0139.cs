using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0139
{
    public bool WordBreak_Ver1(string s, IList<string> wordDict)
    {
        var root = new TrieNode();
        var dp = new bool [s.Length];

        for(var i = 0; i < wordDict.Count; i++)
        {
            var curr = root;

            for(var j = 0; j < wordDict[i].Length; j++)
            {
                if(curr.Get(wordDict[i][j]) == null)
                {
                    curr.Add(wordDict[i][j], new TrieNode());
                }

                curr = curr.Get(wordDict[i][j]);
            }

            curr.Word = wordDict[i];
        }

        for(var i = 0; i < s.Length; i++)
        {
            if(i != 0 && !dp[i-1])
            {
                continue;
            }

            var curr = root;
            for(var j = i; j < s.Length; j++)
            {
                curr = curr.Get(s[j]);

                if(curr == null)
                {
                    break;
                }

                if(!string.IsNullOrEmpty(curr.Word))
                {
                    dp[j] = true;
                }
            }
        }
        
        return dp[s.Length - 1];
    }

    public bool WordBreak_Ver2(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 1];

        dp[0] = true;

        for (var j = 1; j < s.Length + 1; j++)
        {
            for (var i = 0; i < wordDict.Count; i++)
            {
                var startIndex = j - wordDict[i].Length;

                if (startIndex < 0 || !dp[startIndex])
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