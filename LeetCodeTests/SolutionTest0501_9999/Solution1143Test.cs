using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution1143Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LongestCommonSubsequence_Ver1Test(string text1, string text2, int expected)
    {
        var solution = new Solution1143();
        var actual = solution.LongestCommonSubsequence_Ver1(text1, text2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LongestCommonSubsequence_Ver2Test(string text1, string text2, int expected)
    {
        var solution = new Solution1143();
        var actual = solution.LongestCommonSubsequence_Ver2(text1, text2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "abcde",
            "ace",
            3
        },
        new object[]
        {
            "abc",
            "abc",
            3
        },
        new object[]
        {
            "abc",
            "def",
            0
        },
        new object[]
        {
            "abcde",
            "aec",
            2
        },
        new object[]
        {
            "bl",
            "yby",
            1
        },
        new object[]
        {
            "bsbininm",
            "jmjkbkjkv",
            1
        }
    };
}