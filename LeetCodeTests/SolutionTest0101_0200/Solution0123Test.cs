using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0123Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit(int[] prices, int expected)
    {
        var solution = new Solution0123();

        var actual = solution.MaxProfit(prices);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 3, 5, 0, 0, 3, 1, 4 },
            6
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            4
        },
        new object[]
        {
            new int[] { 7, 6, 4, 3, 1 },
            0
        }
    };
}