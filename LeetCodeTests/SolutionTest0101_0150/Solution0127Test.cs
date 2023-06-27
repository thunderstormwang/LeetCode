using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0127Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LadderLength_Ver1Test(string beginWord, string endWord, IList<string> wordList, int expected)
    {
        var solution = new Solution0127();
        var actual = solution.LadderLength_Ver1(beginWord, endWord, wordList);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LadderLength_Ver2Test(string beginWord, string endWord, IList<string> wordList, int expected)
    {
        var solution = new Solution0127();
        var actual = solution.LadderLength_Ver2(beginWord, endWord, wordList);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "hit",
            "cog",
            new string[] { "hot", "dot", "dog", "lot", "log", "cog" },
            5
        },
        new object[]
        {
            "hit",
            "cog",
            new string[] { "hot", "dot", "dog", "lot", "log" },
            0
        }
    };
}