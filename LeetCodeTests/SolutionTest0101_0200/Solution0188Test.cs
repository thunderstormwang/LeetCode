using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0188Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfit(int k, int[] prices, int expected)
    {
        var solution = new Solution0188();

        var actual = solution.MaxProfit(k, prices);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2,
            new int[] { 2, 4, 1 },
            2
        },
        new object[]
        {
            2,
            new int[] { 3, 2, 6, 5, 0, 3 },
            7
        },
    };
}