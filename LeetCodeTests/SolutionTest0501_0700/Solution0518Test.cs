using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0518Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ChangeVer1_Test(int amount, int[] coins, int expected)
    {
        var solution = new Solution0518();
        var actual = solution.Change_Ver1(amount, coins);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void ChangeVer2_Test(int amount, int[] coins, int expected)
    {
        var solution = new Solution0518();
        var actual = solution.Change_Ver2(amount, coins);

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