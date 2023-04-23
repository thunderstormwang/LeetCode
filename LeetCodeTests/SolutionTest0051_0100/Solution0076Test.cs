using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0076Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver1Test(string s, string t, string expected)
    {
        var solution = new Solution0076();
        var actual = solution.MinWindow_Ver1(s, t);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver2Test(string s, string t, string expected)
    {
        var solution = new Solution0076();
        var actual = solution.MinWindow_Ver2(s, t);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "ADOBECODEBANC",
            "ABC",
            "BANC"
        },
        new object[]
        {
            "a",
            "a",
            "a"
        },
        new object[]
        {
            "a",
            "aa",
            ""
        }
    };
}