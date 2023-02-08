using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0518Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ChangeTest(int amount, int[] coins, int expected)
    {
        var solution = new Solution0518();
        var actual = solution.Change(amount, coins);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            5,
            new int[] { 1, 2, 5 },
            4
        },
        new object[]
        {
            3,
            new int[] { 2 },
            0
        },
        new object[]
        {
            10,
            new int[] { 10 },
            1
        }
    };
}