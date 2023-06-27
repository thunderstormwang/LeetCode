using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0122Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit_GreedyTest(int[] prices, int expected)
    {
        var solution = new Solution0122();

        var actual = solution.MaxProfit_Greedy(prices);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit_DPTest(int[] prices, int expected)
    {
        var solution = new Solution0122();

        var actual = solution.MaxProfit_DP(prices);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 7, 1, 5, 3, 6, 4 },
            7
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
        },
        new object[]
        {
            new int[] { 7 },
            0
        }
    };
}