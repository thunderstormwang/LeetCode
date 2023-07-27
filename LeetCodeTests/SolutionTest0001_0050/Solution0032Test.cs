using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0032Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NextPermutation_Ver1Test(string s, int expected)
    {
        var solution = new Solution0032();
        var actual = solution.LongestValidParentheses(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "(()",
            2
        },
        new object[]
        {
            ")()())",
            4
        },
        new object[]
        {
            "",
            0
        },
        new object[]
        {
            "(()()",
            4
        },
        new object[]
        {
            ")()())",
            4
        },
        new object[]
        {
            "((((()",
            2
        },
    };
}