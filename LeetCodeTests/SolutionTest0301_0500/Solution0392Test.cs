using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0392Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsSubsequenceTest(string s, string t, bool expected)
    {
        var solution = new Solution0392();
        var actual = solution.IsSubsequence_TwoPointer(s, t);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void IsSubsequence_DP_Ver1Test(string s, string t, bool expected)
    {
        var solution = new Solution0392();
        var actual = solution.IsSubsequence_DP_Ver1(s, t);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void IsSubsequence_DP_Ver2Test(string s, string t, bool expected)
    {
        var solution = new Solution0392();
        var actual = solution.IsSubsequence_DP_Ver2(s, t);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "abc",
            "ahbgdc",
            true
        },
        new object[]
        {
            "axc",
            "ahbgdc",
            false
        },
        new object[]
        {
            "acb",
            "ahbgdc",
            false
        },
        new object[]
        {
            "aaaaaa",
            "bbaaaa",
            false
        }
    };
}