using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0844Test
{
    [TestCaseSource(nameof(TestCases))]
    public void BackspaceCompare_Ver1Test(string s, string t, bool expected)
    {
        var solution = new Solution0844();
        var actual = solution.BackspaceCompare_Ver1(s, t);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void BackspaceCompare_Ver2Test(string s, string t, bool expected)
    {
        var solution = new Solution0844();
        var actual = solution.BackspaceCompare_Ver2(s, t);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "ab#c",
            "ad#c",
            true
        },
        new object[]
        {
            "ab##",
            "c#d#",
            true
        },
        new object[]
        {
            "a#c",
            "b",
            false
        },
        new object[]
        {
            "nzp#o#g",
            "b#nzp#o#g",
            true
        },
        new object[]
        {
            "bbbextm",
            "bbb#extm",
            false
        }
    };
}