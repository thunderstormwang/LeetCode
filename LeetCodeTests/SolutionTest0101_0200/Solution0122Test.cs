using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
public class Solution0122Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxProfitTest(int[] array, int expected)
    {
        var solution = new Solution0122();

        var actual = solution.MaxProfit(array);

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