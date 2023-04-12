using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0746Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinCostClimbingStairsTest(int[] cost, int expected)
    {
        var solution = new Solution0746();
        var actual = solution.MinCostClimbingStairs(cost);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 10, 15, 20 },
            15
        },
        new object[]
        {
            new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 },
            6
        }
    };
}