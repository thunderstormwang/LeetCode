using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0455Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindContentChildren(int[] g, int []s, int expected)
    {
        var solution = new Solution0455();
        var actual = solution.FindContentChildren(g, s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 1, 1 },
            1
        },
        new object[]
        {
            new int[] { 1, 2 },
            new int[] { 1, 2, 3 },
            2
        }
    };
}