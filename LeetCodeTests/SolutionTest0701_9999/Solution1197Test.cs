using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution1197Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinKnightMovesTest(int x, int y, int expected)
    {
        var solution = new Solution1197();
        var actual = solution.MinKnightMoves(x, y);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2,
            1,
            1
        },
        new object[]
        {
            5,
            5,
            4
        },
        new object[]
        {
            0,
            0,
            0
        }
    };
}