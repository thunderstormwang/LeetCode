using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0309Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumSquares_Ver1Test(int[] prices, int expected)
    {
        var solution = new Solution0309();
        var actual = solution.MaxProfit_Ver1(prices);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void NumSquares_Ver2Test(int[] prices, int expected)
    {
        var solution = new Solution0309();
        var actual = solution.MaxProfit_Ver2(prices);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 0, 2 },
            3
        },
        new object[]
        {
            new int[] { 1 },
            0
        },
        new object[]
        {
            new int[] { 1, 2, 4 },
            3
        }
    };
}