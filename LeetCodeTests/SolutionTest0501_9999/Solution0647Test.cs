using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0647Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CountSubstrings_MyAnswerVer1Test(string s, int expected)
    {
        var solution = new Solution0647();

        var actual = solution.CountSubstrings_MyAnswerVer1(s);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void CountSubstrings_MyAnswerVer2Test(string s, int expected)
    {
        var solution = new Solution0647();

        var actual = solution.CountSubstrings_MyAnswerVer2(s);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void CountSubstrings_DPTest(string s, int expected)
    {
        var solution = new Solution0647();

        var actual = solution.CountSubstrings_DP(s);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void CountSubstrings_TwoPointerTest(string s, int expected)
    {
        var solution = new Solution0647();

        var actual = solution.CountSubstrings_TwoPointer(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "abc",
            3
        },
        new object[]
        {
            "aaa",
            6
        },
        new object[]
        {
            "fdsklf",
            6
        }
    };
}