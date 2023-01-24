using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0062Test
{
    [TestCaseSource(nameof(TestCases))]
    public void UniquePathsTest(int m, int n, int expected)
    {
        var solution = new Solution0062();
        var actual = solution.UniquePaths(m, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            3,
            2,
            3
        },
        new object[]
        {
            3,
            7,
            28
        }
    };
}