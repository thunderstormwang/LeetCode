using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0516Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LongestPalindromeSubseqTest(string s, int expected)
    {
        var solution = new Solution0516();
        var actual = solution.LongestPalindromeSubseq(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "bbbab",
            4
        },
        new object[]
        {
            "cbbd",
            2
        }
    };
}