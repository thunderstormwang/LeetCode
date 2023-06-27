using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0714Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit_GreedyTest(int[] prices, int fee, int expected)
    {
        var solution = new Solution0714();
        var actual = solution.MaxProfit_Greedy(prices, fee);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit_DPTest(int[] prices, int fee, int expected)
    {
        var solution = new Solution0714();
        var actual = solution.MaxProfit_DP(prices, fee);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 3, 2, 8, 4, 9 },
            2,
            8
        },
        new object[]
        {
            new int[] { 1, 3, 7, 5, 10, 3 },
            3,
            6
        },
        new object[]
        {
            new int[] { 1, 3, 8, 5, 10, 3 },
            3,
            6
        },
        new object[]
        {
            new int[] { 1, 8, 7, 20 },
            2,
            17
        }
    };
}